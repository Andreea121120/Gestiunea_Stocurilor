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
    public partial class frmModifFactura : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifFactura()
        {
            InitializeComponent();
        }

        private void frmModifFactura_Load(object sender, EventArgs e)
        {
            ctx.Factura.Load();
            ctx.Partener.Load();
 

            facturaBindingSource.DataSource = ctx.Factura.Local.ToBindingList();
            partenerBindingSource.DataSource = ctx.Partener.Local.Where(p => p.TipPartener == "Furnizor").ToList();
            partenerBindingSource1.DataSource = ctx.Partener.Local.Where(p => p.TipPartener == "Client").ToList();

            var furnizor = (DataGridViewComboBoxColumn)facturaDataGridView.Columns["IdPartenerFurnizor"];
            furnizor.DataSource = partenerBindingSource;

            var client = (DataGridViewComboBoxColumn)facturaDataGridView.Columns["IdPartenerClient"];
            client.DataSource = partenerBindingSource1;
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                facturaBindingSource.EndEdit();

                var listaFacturi = ctx.Factura.Local
                    .Where(f => !string.IsNullOrEmpty(f.Numar))
                    .ToList();

                var duplicat = listaFacturi
                    .GroupBy(f => f.Numar.Trim())
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicat.Any())
                {
                    string msg = "Nu se poate salva. Numărul facturii duplicat: " + string.Join(", ", duplicat)+"!";
                    MessageBox.Show(msg, "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                ctx.SaveChanges();
                facturaBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void facturaDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = facturaDataGridView.Rows[e.RowIndex];
            var cellFurnizor = row.Cells["IdPartenerFurnizor"];
            var cellClient = row.Cells["IdPartenerClient"];

            var valFurnizor = cellFurnizor.Value;
            var valClient = cellClient.Value;

            if (valFurnizor != null && valClient != null)
            {
                // Daca ambele sunt completate => anuleaza ultima modificare
                facturaDataGridView.CellValueChanged -= facturaDataGridView_CellValueChanged;

                // Decide care sa fie anulata - presupunem ca ultima celula editata e cea de la eveniment
                if (e.ColumnIndex == facturaDataGridView.Columns["IdPartenerFurnizor"].Index)
                {
                    cellFurnizor.Value = null;
                }
                else if (e.ColumnIndex == facturaDataGridView.Columns["IdPartenerClient"].Index)
                {
                    cellClient.Value = null;
                }

                MessageBox.Show("Factura trebuie să aibă un singur partener: client sau furnizor!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                facturaDataGridView.CellValueChanged += facturaDataGridView_CellValueChanged;
            }
        }

        private void facturaDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!facturaDataGridView.IsCurrentRowDirty)
                return;

            var row = facturaDataGridView.Rows[e.RowIndex];

            string numar = row.Cells["dataGridViewTextBoxColumn3"]?.Value?.ToString()?.Trim();
            var data = row.Cells["dataGridViewTextBoxColumn5"]?.Value;
            var idFurnizor = row.Cells["IdPartenerFurnizor"]?.Value;
            var idClient = row.Cells["IdPartenerClient"]?.Value;

            bool eroare = false;
            StringBuilder mesaj = new StringBuilder("Completează corect câmpurile:\n");

            if (string.IsNullOrWhiteSpace(numar))
            {
                mesaj.AppendLine("- Numar");
                eroare = true;
            }

            if (data == null || !DateTime.TryParse(data.ToString(), out _))
            {
                mesaj.AppendLine("- Data");
                eroare = true;
            }

            if ((idFurnizor == null && idClient == null) || (idFurnizor != null && idClient != null))
            {
                mesaj.AppendLine("- Trebuie completat fie Furnizor, fie Client, dar nu ambele!");
                eroare = true;
            }

            if (eroare)
            {
                row.DefaultCellStyle.BackColor = Color.MistyRose;
                MessageBox.Show(mesaj.ToString(), "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
