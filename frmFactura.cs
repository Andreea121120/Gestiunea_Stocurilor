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
    public partial class frmFactura : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            ctx.Factura.Load();
            ctx.ContinutFactura.Load();
            ctx.Produs.Load();
            ctx.Partener.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            partenerBindingSource.DataSource = ctx.Partener.Local
                .Where(p => p.TipPartener.ToLower() == "client")
                .ToList();

            partenerBindingSource1.DataSource = ctx.Partener.Local
                .Where(p => p.TipPartener.ToLower() == "furnizor")
                .ToList();

            rbClient.Checked = true;
            idPartenerClientComboBox.Visible = true;
            idPartenerFurnizorComboBox.Visible = false;
        }

        private void CalculeazaTotalBifat()
        {
            decimal total = 0;

            foreach (DataGridViewRow rand in continutFacturaDataGridView.Rows)
            {
                var selecteaza = rand.Cells["Column1"] as DataGridViewCheckBoxCell;

                if (selecteaza != null && Convert.ToBoolean(selecteaza.Value))
                {
                    if (rand.DataBoundItem is ContinutFactura cf)
                    {
                        total += cf.Valoare;
                    }
                }
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private bool ValidareRanduriSelectate()
        {
            foreach (DataGridViewRow rand in continutFacturaDataGridView.Rows)
            {
                var selecteaza = rand.Cells["Column1"] as DataGridViewCheckBoxCell;

                if (selecteaza != null && Convert.ToBoolean(selecteaza.Value))
                {
                    // Verifică dacă DataBoundItem e valid
                    if (!(rand.DataBoundItem is ContinutFactura cf))
                    {
                        MessageBox.Show("Ai bifat un rând invalid!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Verifică valoarea efectivă din celula IdProdus
                    if (rand.Cells["dataGridViewTextBoxColumn3"].Value == null)
                    {
                        MessageBox.Show("Ai bifat un rând fără produs selectat!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Verificare preț
                    if (rand.Cells["dataGridViewTextBoxColumn4"].Value == null ||
                        !decimal.TryParse(rand.Cells["dataGridViewTextBoxColumn4"].Value.ToString(), out decimal pret) || pret <= 0)
                    {
                        MessageBox.Show("Ai bifat un rând cu preț invalid (lipsă sau <= 0)!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Verificare cantitate
                    if (rand.Cells["dataGridViewTextBoxColumn5"].Value == null ||
                        !decimal.TryParse(rand.Cells["dataGridViewTextBoxColumn5"].Value.ToString(), out decimal cantitate) || cantitate <= 0)
                    {
                        MessageBox.Show("Ai bifat un rând cu cantitate invalidă (lipsă sau <= 0)!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }


        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(numarTextBox.Text))
                {
                    MessageBox.Show("Introdu un număr de factură!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nrF = numarTextBox.Text.Trim();
                if (ctx.Factura.Any(f => f.Numar == nrF))
                {
                    MessageBox.Show($"Există deja o factură cu numărul \"{nrF}\"!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Finalizează editarea curentă în DataGridView și BindingSource
                continutFacturaDataGridView.EndEdit();
                continutFacturaBindingSource.EndEdit();

                // Validare completă pe toate rândurile selectate
                if (!ValidareRanduriSelectate())
                {
                    return;
                }

                // Extrage rândurile selectate cu valori corecte
                var produseSelectate = new List<ContinutFactura>();
                foreach (DataGridViewRow rand in continutFacturaDataGridView.Rows)
                {
                    var selecteaza = rand.Cells["Column1"] as DataGridViewCheckBoxCell;

                    if (selecteaza != null && Convert.ToBoolean(selecteaza.Value))
                    {
                        ContinutFactura cf = rand.DataBoundItem as ContinutFactura;

                        if (cf != null && cf.Pret > 0 && cf.IdFactura == null)
                        {
                            produseSelectate.Add(cf);
                        }
                    }
                }

                if (produseSelectate.Count == 0)
                {
                    MessageBox.Show("Rândul este incomplet sau produsul nu a fost selectat pentru facturare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Factura factura = new Factura
                {
                    Numar = numarTextBox.Text,
                    Serie = serieTextBox.Text,
                    Data = dataDateTimePicker.Value,
                    Explicatii = explicatiiTextBox.Text
                };

                if (rbClient.Checked && idPartenerClientComboBox.SelectedValue != null)
                {
                    factura.IdPartenerClient = (int)idPartenerClientComboBox.SelectedValue;
                }
                else if (rbFurnizor.Checked && idPartenerFurnizorComboBox.SelectedValue != null)
                {
                    factura.IdPartenerFurnizor = (int)idPartenerFurnizorComboBox.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Selectează un partener!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ctx.Factura.Add(factura);
                ctx.SaveChanges();

                foreach (var cf in produseSelectate)
                {
                    ContinutFactura continutf = new ContinutFactura
                    {
                        IdFactura = factura.Id,
                        IdProdus = cf.IdProdus,
                        Cantitate = cf.Cantitate,
                        Pret = cf.Pret
                    };

                    ctx.ContinutFactura.Add(continutf);
                }

                ctx.SaveChanges();

                facturaBindingSource.ResetBindings(false);

                continutFacturaBindingSource.DataSource = new BindingList<ContinutFactura>();
                continutFacturaBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void continutFacturaDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var colName = continutFacturaDataGridView.Columns[e.ColumnIndex].Name;

                if (colName == "Column1")
                {
                    CalculeazaTotalBifat();
                }
            }
        }

        private void continutFacturaDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (continutFacturaDataGridView.IsCurrentCellDirty)
            {
                var col = continutFacturaDataGridView.CurrentCell.OwningColumn;
                if (col.Name == "Column1")
                {
                    continutFacturaDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaFacturi lf = new frmListaFacturi();
            lf.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifFactura mf = new frmModifFactura();
            mf.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            frmStocCurent sc = new frmStocCurent();
            sc.Show();
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClient.Checked)
            {
                idPartenerClientComboBox.Visible = true;
                idPartenerFurnizorComboBox.Visible = false;
            }
        }

        private void rbFurnizor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFurnizor.Checked)
            {
                idPartenerClientComboBox.Visible = false;
                idPartenerFurnizorComboBox.Visible = true;
            }
        }
    }
}
