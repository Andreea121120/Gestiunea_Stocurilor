using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Gestiunea_stocurilor
{
    public partial class frmModifAvixExped : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifAvixExped()
        {
            InitializeComponent();
        }

        private void frmModifAvixExped_Load(object sender, EventArgs e)
        {
            ctx.AvizExpeditie.Load();
            ctx.Depozit.Load();
            ctx.Factura.Where(f => f.IdPartenerClient != null).Load();

            avizExpeditieBindingSource.DataSource = ctx.AvizExpeditie.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            facturaBindingSource.DataSource = ctx.Factura.Local.ToBindingList();
        }

        private void avizExpeditieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                avizExpeditieBindingSource.EndEdit();
                depozitBindingSource.EndEdit();
                facturaBindingSource.EndEdit();

                foreach (AvizExpeditie avizExpeditie in ctx.AvizExpeditie.Local)
                {

                    bool numarDuplicat = ctx.AvizExpeditie.Local.Any(a =>
                        a.Numar == avizExpeditie.Numar &&
                        a.Id != avizExpeditie.Id);

                    if (numarDuplicat)
                    {
                        MessageBox.Show($"Numărul '{avizExpeditie.Numar}' este deja folosit de un alt Aviz de expediție!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica daca este schimbata factura in AvizExpeditie
                    if (avizExpeditie.IdFactura != null)
                    {
                        int idFactura = avizExpeditie.IdFactura.Value;
                        int idDepozit = avizExpeditie.IdDepozit.Value;

                        // Se verifica daca produsele din factura se afla în depozit
                        var produseInFactura = ctx.ContinutFactura
                            .Where(cf => cf.IdFactura == idFactura)
                            .Select(cf => cf.IdProdus)
                            .ToList();

                        var produseInDepozit = ctx.ProdusGestionat
                            .Where(pg => pg.IdDepozit == idDepozit)
                            .Select(pg => pg.IdProdus)
                            .ToList();

                        var produseLipsaInDepozit = produseInFactura.Except(produseInDepozit).ToList();

                        if (produseLipsaInDepozit.Any())
                        {
                            string lipsaText = string.Join(", ", produseLipsaInDepozit.Select(id =>
                            {
                                var p = ctx.Produs.Find(id);
                                return p != null ? p.Denumire : $"ID: {id}";
                            }));

                            MessageBox.Show($"Nu poți atribui această factură/depozit!\nUrmătoarele produse din factură nu se regăsesc în depozitul ales:\n{lipsaText}",
                                "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Verifica daca ContinutAvizExpeditie corespunde cu ContinutFactura
                        var continutFactura = ctx.ContinutFactura
                            .Where(cf => cf.IdFactura == idFactura)
                            .Select(cf => new { cf.IdProdus, cf.Cantitate, cf.Pret })
                            .OrderBy(cf => cf.IdProdus)
                            .ToList();

                        var produsExpeditie = ctx.ProdusExpeditie
                            .Where(cae => cae.IdAvizExpeditie == avizExpeditie.Id)
                            .Select(cae => new { cae.IdProdus, cae.Cantitate })
                            .OrderBy(cae => cae.IdProdus)
                            .ToList();

                        bool continutIdentic = true;

                        // Creeaza un dicționar din ContinutAvizExpeditie: [IdProdus] => Cantitate
                        var dictAE = produsExpeditie.ToDictionary(c => c.IdProdus, c => c.Cantitate);

                        // Parcurge ContinutFactura și compara fiecare produs și cantitate
                        foreach (var cf in continutFactura)
                        {
                            if (!dictAE.TryGetValue(cf.IdProdus, out var cantAE) || cantAE != cf.Cantitate)
                            {
                                continutIdentic = false;
                                break;
                            }
                        }

                        if (continutFactura.Count != produsExpeditie.Count)
                        {
                            continutIdentic = false;
                        }

                        if (!continutIdentic)
                        {
                            MessageBox.Show("Conținutul facturii nu corespunde cu conținutul Avizului de expediție!\nVerifică produsele și cantitățile.",
                                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                }

                ctx.SaveChanges();

                avizExpeditieBindingSource.ResetBindings(false);
                depozitBindingSource.ResetBindings(false);
                facturaBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void avizExpeditieDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (avizExpeditieDataGridView.IsCurrentRowDirty)
            {
                var rand = avizExpeditieDataGridView.Rows[e.RowIndex];

                string numar = rand.Cells["dataGridViewTextBoxColumn3"]?.Value?.ToString()?.Trim();
                var data = rand.Cells["dataGridViewTextBoxColumn4"]?.Value;
                var idDepozit = rand.Cells["dataGridViewTextBoxColumn2"]?.Value;
                var idFactura = rand.Cells["IdFactura"]?.Value;

                bool eroare = false;
                StringBuilder mesaj = new StringBuilder("Completează câmpurile obligatorii:\n");

                if (string.IsNullOrWhiteSpace(numar))
                {
                    eroare = true;
                    mesaj.AppendLine("- Număr");
                }
                if (data == null || !DateTime.TryParse(data.ToString(), out _))
                {
                    eroare = true;
                    mesaj.AppendLine("- Dată");
                }
                if (idDepozit == null)
                {
                    eroare = true;
                    mesaj.AppendLine("- Depozit");
                }
                if (idFactura == null)
                {
                    eroare = true;
                    mesaj.AppendLine("- Factură");
                }

                if (eroare)
                {
                    rand.DefaultCellStyle.BackColor = Color.MistyRose;
                    MessageBox.Show(mesaj.ToString(), "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                else
                {
                    rand.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
