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
    public partial class frmModifBonConsum : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifBonConsum()
        {
            InitializeComponent();
        }

        private void frmModifBonConsum_Load(object sender, EventArgs e)
        {
            ctx.BonConsum.Load();
            ctx.Depozit.Load();

            bonConsumBindingSource.DataSource = ctx.BonConsum.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
        }

        private void bonConsumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                bonConsumBindingSource.EndEdit();
                depozitBindingSource.EndEdit();

                var listaBonuri = ctx.BonConsum.Local
                    .Where(bc => !string.IsNullOrEmpty(bc.Numar))
                    .ToList();

                var duplicat = listaBonuri
                    .GroupBy(bc => bc.Numar.Trim())
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicat.Any())
                {
                    string msg = "Nu se poate salva. Numărul duplicat: " + string.Join(", ", duplicat)+"!";
                    MessageBox.Show(msg, "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (BonConsum bon in ctx.BonConsum.Local)
                {
                    if (bon.IdDepozit != null)
                    {
                        int idDepozit = bon.IdDepozit.Value;

                        // Produsele din bon
                        var produseInBon = ctx.ProdusConsum
                            .Where(cb => cb.IdBonConsum == bon.Id)
                            .Select(cb => cb.IdProdus)
                            .ToList();

                        // Produsele din depozit
                        var produseInDepozit = ctx.ProdusGestionat
                            .Where(pg => pg.IdDepozit == idDepozit)
                            .Select(pg => pg.IdProdus)
                            .ToList();

                        // Verificare lipsa produse
                        var produseLipsa = produseInBon.Except(produseInDepozit).ToList();

                        if (produseLipsa.Any())
                        {
                            string lipsaText = string.Join(", ", produseLipsa.Select(id =>
                            {
                                var p = ctx.Produs.Find(id);
                                return p != null ? p.Denumire : $"ID: {id}";
                            }));

                            MessageBox.Show($"Nu poți selecta acest depozit pentru bonul de consum!\nUrmătoarele produse lipsesc din depozit:\n{lipsaText}",
                                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ctx.SaveChanges();
                bonConsumBindingSource.ResetBindings(false);
                depozitBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bonConsumDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (bonConsumDataGridView.IsCurrentRowDirty)
            {
                var rand = bonConsumDataGridView.Rows[e.RowIndex];

                string numar = rand.Cells["dataGridViewTextBoxColumn4"]?.Value?.ToString()?.Trim();
                var data = rand.Cells["dataGridViewTextBoxColumn5"]?.Value;
                var idDepozit = rand.Cells["dataGridViewTextBoxColumn2"]?.Value;

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

                if (eroare)
                {
                    rand.DefaultCellStyle.BackColor = Color.MistyRose;
                    MessageBox.Show(mesaj.ToString(), "Atenționare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
