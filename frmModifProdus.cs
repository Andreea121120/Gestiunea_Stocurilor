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
    public partial class frmModifProdus : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifProdus()
        {
            InitializeComponent();
        }

        private void frmModifProdus_Load(object sender, EventArgs e)
        {
            ctx.Produs.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
        }

        private void produsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                produsBindingSource.EndEdit();

                var listaProduse = ctx.Produs.Local.ToList();

                foreach (var produs in listaProduse)
                {
                    // Verificare: Codul este completat și pozitiv
                    if (!produs.Cod.HasValue)
                    {
                        MessageBox.Show($"Produsul cu ID-ul {produs.Id} nu are un cod valid.",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int nrDuplicate = listaProduse.Count(p => p.Cod == produs.Cod && p.Id != produs.Id);
                    if (nrDuplicate > 0)
                    {
                        MessageBox.Show($"Codul '{produs.Cod}' este deja folosit de alt produs!",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(produs.Denumire))
                    {
                        MessageBox.Show($"Produsul cu codul {produs.Cod} nu are denumirea completată.",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(produs.UnitateDeMasura))
                    {
                        MessageBox.Show($"Produsul \"{produs.Denumire}\" nu are unitatea de măsură completată.",
                            "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ctx.SaveChanges();
                produsBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void produsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && produsDataGridView.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                Produs produs = (Produs)produsDataGridView.Rows[e.RowIndex].DataBoundItem;

                if (produs != null)
                {
                    int idProdus = produs.Id;

                    if (ctx.Material.Any(m => m.IdProdus == idProdus))
                    {
                        var form = new frmModifMaterial(idProdus);
                        form.ShowDialog();
                    }
                    if (ctx.MateriePrima.Any(mp => mp.IdProdus == idProdus))
                    {
                        var form = new frmModifMP(idProdus);
                        form.ShowDialog();
                    }
                    if (ctx.Marfa.Any(mf => mf.IdProdus == idProdus))
                    {
                        var form = new frmModifMarfa(idProdus);
                        form.ShowDialog();
                    }
                    if (ctx.ProdusFinit.Any(pf => pf.IdProdus == idProdus))
                    {
                        var form = new frmModifPF(idProdus);
                        form.ShowDialog();
                    }
                }
            }
        }

        private void produsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.ToLower(); 

            var filteredProdus = ctx.Produs.Local.Where(p => p.Cod.HasValue && p.Cod.Value.ToString().ToLower().Contains(searchTerm)).ToList();

            produsBindingSource.DataSource = filteredProdus;

            produsBindingSource.ResetBindings(false);
        }

        private void produsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (produsDataGridView.Columns[e.ColumnIndex].Name == "TipProdus")
            {
                var row = produsDataGridView.Rows[e.RowIndex];

                if (row.IsNewRow || row.DataBoundItem == null)
                    return;

                var produs = produsDataGridView.Rows[e.RowIndex].DataBoundItem as Produs;
                if (produs != null)
                {
                    int idProdus = produs.Id;
                    List<string> tipuri = new List<string>();

                    if (ctx.Material.Any(m => m.IdProdus == idProdus)) tipuri.Add("Material");
                    if (ctx.MateriePrima.Any(mp => mp.IdProdus == idProdus)) tipuri.Add("Materie prima");
                    if (ctx.Marfa.Any(mf => mf.IdProdus == idProdus)) tipuri.Add("Marfa");
                    if (ctx.ProdusFinit.Any(pf => pf.IdProdus == idProdus)) tipuri.Add("Produs finit");

                    e.Value = string.Join(", ", tipuri);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAdaugaProdusCategorie pg = new frmAdaugaProdusCategorie();
            pg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmStocCurent sc = new frmStocCurent();
            sc.Show();
        }
    }
}
