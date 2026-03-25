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
    public partial class frmModifBonTransf : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifBonTransf()
        {
            InitializeComponent();
        }

        private void frmModifBonTransf_Load(object sender, EventArgs e)
        {
            ctx.BonTransfer.Load();
            ctx.Depozit.Load();

            bonTransferBindingSource.DataSource = ctx.BonTransfer.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
        }

        private void bonTransferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bonTransferBindingSource.EndEdit();
                depozitBindingSource.EndEdit();

                var listaBonuri = ctx.BonTransfer.Local
            .Where(bt => !string.IsNullOrEmpty(bt.Numar))
            .ToList();

                var duplicate = listaBonuri
                    .GroupBy(bt => bt.Numar.Trim())
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicate.Any())
                {
                    string msg = "Nu se poate salva. Numărul duplicat: " + string.Join(", ", duplicate)+"!";
                    MessageBox.Show(msg, "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ctx.SaveChanges();
                bonTransferBindingSource.ResetBindings(false);
                depozitBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bonTransferDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (bonTransferDataGridView.IsCurrentRowDirty)
            {
                var rand = bonTransferDataGridView.Rows[e.RowIndex];

                string numar = rand.Cells["dataGridViewTextBoxColumn3"]?.Value?.ToString()?.Trim();
                var data = rand.Cells["dataGridViewTextBoxColumn4"]?.Value;
                var depPredator = rand.Cells["dataGridViewTextBoxColumn2"]?.Value;
                var depPrimitor = rand.Cells["dataGridViewTextBoxColumn5"]?.Value;

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
                if (depPredator == null)
                {
                    eroare = true;
                    mesaj.AppendLine("- Depozit predator");
                }
                if (depPrimitor == null)
                {
                    eroare = true;
                    mesaj.AppendLine("- Depozit primitor");
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
