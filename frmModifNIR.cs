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
    public partial class frmModifNIR : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifNIR()
        {
            InitializeComponent();
        }

        private void frmModifNIR_Load(object sender, EventArgs e)
        {
            ctx.NIR.Load();
            ctx.Depozit.Load();
            ctx.Factura.Where(f => f.IdPartenerFurnizor != null).Load();

            nIRBindingSource.DataSource = ctx.NIR.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            facturaBindingSource.DataSource = ctx.Factura.Local.ToBindingList();
        }

        private void nIRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                nIRBindingSource.EndEdit();
                depozitBindingSource.EndEdit();
                facturaBindingSource.EndEdit();

                var modifiedEntries = ctx.ChangeTracker.Entries<NIR>()
                                         .Where(en => en.State == EntityState.Modified)
                                         .ToList();

                foreach (var entry in modifiedEntries)
                {
                    var nir = entry.Entity;

                    bool numarDuplicat = ctx.NIR.Local.Any(n =>
                        n.Numar == nir.Numar &&
                        n.Id != nir.Id);

                    if (numarDuplicat)
                    {
                        MessageBox.Show($"Numărul '{nir.Numar}' este deja folosit de un alt NIR!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica daca s-a modificat IdFactura sau IdDepozit
                    bool facturaModificata = entry.Property(nameof(nir.IdFactura)).IsModified;
                    bool depozitModificat = entry.Property(nameof(nir.IdDepozit)).IsModified;

                    if (nir.IdFactura != null && (facturaModificata || depozitModificat))
                    {
                        int idFactura = nir.IdFactura.Value;
                        int idDepozit = nir.IdDepozit.Value;

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

                            MessageBox.Show($"Nu poți atribui această factură/ depozit!\nUrmătoarele produse din factură nu se regăsesc în depozitul ales:\n{lipsaText}",
                                "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Verifica daca ContinutNIR corespunde cu ContinutFactura
                        var continutNIR = ctx.ContinutNIR
                            .Where(cn => cn.IdNIR == nir.Id)
                            .Select(cn => new { cn.IdProdus, cn.Cantitate })
                            .OrderBy(cn => cn.IdProdus)
                            .ToList();

                        bool continutIdentic = true;

                        // Creeaza un dicționar din ContinutNIR: [IdProdus] => Cantitate
                        var dictNIR = continutNIR.ToDictionary(c => c.IdProdus, c => c.Cantitate);

                        // Parcurge ContinutFactura si compara fiecare produs și cantitate
                        var continutFactura = ctx.ContinutFactura
                            .Where(cf => cf.IdFactura == idFactura)
                            .Select(cf => new { cf.IdProdus, cf.Cantitate, cf.Pret })
                            .OrderBy(cf => cf.IdProdus)
                            .ToList();

                        foreach (var cf in continutFactura)
                        {
                            if (!dictNIR.TryGetValue(cf.IdProdus, out var cantNIR) || cantNIR != cf.Cantitate)
                            {
                                continutIdentic = false;
                                break;
                            }
                        }

                        if (continutFactura.Count != continutNIR.Count)
                        {
                            continutIdentic = false;
                        }

                        if (!continutIdentic)
                        {
                            MessageBox.Show("Există discrepanțe între factura și NIR!\nCorectează informațiile pentru validare.",
                                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ctx.SaveChanges();

                nIRBindingSource.ResetBindings(false);
                depozitBindingSource.ResetBindings(false);
                facturaBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nIRDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!nIRDataGridView.IsCurrentRowDirty)
                return;

            var row = nIRDataGridView.Rows[e.RowIndex];

            var numar = row.Cells["dataGridViewTextBoxColumn4"]?.Value?.ToString()?.Trim();
            var data = row.Cells["dataGridViewTextBoxColumn5"]?.Value;
            var idDepozit = row.Cells["dataGridViewTextBoxColumn2"]?.Value;
            var idFactura = row.Cells["dataGridViewTextBoxColumn3"]?.Value;

            bool eroare = false;
            StringBuilder msg = new StringBuilder("Trebuie completate corect următoarele câmpuri:\n");

            if (string.IsNullOrWhiteSpace(numar))
            {
                msg.AppendLine("- Numar");
                eroare = true;
            }

            if (data == null || !DateTime.TryParse(data.ToString(), out _))
            {
                msg.AppendLine("- Data");
                eroare = true;
            }

            if (idDepozit == null)
            {
                msg.AppendLine("- Depozit");
                eroare = true;
            }

            if (idFactura == null)
            {
                msg.AppendLine("- Factura");
                eroare = true;
            }

            if (eroare)
            {
                row.DefaultCellStyle.BackColor = Color.MistyRose;
                MessageBox.Show(msg.ToString(), "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
