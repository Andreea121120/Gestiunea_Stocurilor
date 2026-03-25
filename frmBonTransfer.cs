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
    public partial class frmBonTransfer : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmBonTransfer()
        {
            InitializeComponent();
        }

        private void frmBonTransfer_Load(object sender, EventArgs e)
        {
            ctx.BonTransfer.Load();
            ctx.ProdusTransfer.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            depozitBindingSource1.DataSource = ctx.Depozit.Local.ToBindingList();
            //produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();

            idDepozitPredatorComboBox.SelectedIndex = -1;
            idDepozitPrimitorComboBox.SelectedIndex = -1;

        }
        public int StocCurent(int idProdus, int idDepozit, DateTime data)
        {
            string sql = "SELECT StocCurent FROM dbo.StocCurentTB(@p0, @p1, @p2)";
            return ctx.Database.SqlQuery<int>(sql, idProdus, idDepozit, data).FirstOrDefault();
        }

        private void bonTransferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(numarTextBox.Text))
                {
                    MessageBox.Show("Introdu un număr Bon transfer!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (idDepozitPredatorComboBox.SelectedIndex < 0 || idDepozitPrimitorComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Selectează ambele depozite!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((int)idDepozitPredatorComboBox.SelectedValue == (int)idDepozitPrimitorComboBox.SelectedValue)
                {
                    MessageBox.Show("Depozitul predator și depozitul primitor nu pot fi identice!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string nrBT = numarTextBox.Text.Trim();
                if (ctx.BonTransfer.Any(bt => bt.Numar == nrBT))
                {
                    MessageBox.Show($"Există deja un bon de transfer cu numărul \"{nrBT}\"!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Validate();

                bonTransferBindingSource.EndEdit();
                produsTransferBindingSource.EndEdit();
                depozitBindingSource.EndEdit();
                produsBindingSource.EndEdit();

                bool existaRand = false;

                // Se verifica daca sunt introduse date in toate campurile de pe un rand 
                // Nu se salveaza Bonul de transfer daca nu este introdus nimic in produsTransferDataGridView
                foreach (DataGridViewRow rand in produsTransferDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["dataGridViewTextBoxColumn4"].Value;

                    if (produs != null && cantitate != null)
                    {
                        if (!decimal.TryParse(cantitate.ToString(), out decimal valCantitate) || valCantitate <= 0)
                        {
                            string denumireProdus = ctx.Produs.Find((int)produs)?.Denumire ?? $"Produs ID {produs}";
                            MessageBox.Show($"Cantitatea introdusă pentru produsul \"{denumireProdus}\" trebuie să fie mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        existaRand = true;
                        break; 
                    }
                }

                if (!existaRand)
                {
                    MessageBox.Show("Completează cel puțin un rând în tabelul de mai jos!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BonTransfer bonTransfer = new BonTransfer
                {
                    IdDepozitPredator = (int)idDepozitPredatorComboBox.SelectedValue,
                    IdDepozitPrimitor = (int)idDepozitPrimitorComboBox.SelectedValue,
                    Numar = numarTextBox.Text,
                    Data = dataDateTimePicker.Value
                };

                foreach (DataGridViewRow rand in produsTransferDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["dataGridViewTextBoxColumn4"].Value;

                    if (produs == null || cantitate == null) continue;

                    int idProdus = (int)produs;
                    decimal Cantitate = Convert.ToDecimal(cantitate);

                    if (Cantitate <= 0)
                    {
                        string denumireProdus = ctx.Produs.Find(idProdus)?.Denumire ?? $"Produs ID {idProdus}";
                        MessageBox.Show($"Cantitatea introdusă pentru produsul \"{denumireProdus}\" trebuie să fie mai mare decât zero!", "Cantitate invalidă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idDepozit = (int)idDepozitPredatorComboBox.SelectedValue;
                    DateTime dataNIR = dataDateTimePicker.Value;

                    int stocCurent = StocCurent(idProdus, idDepozit, dataNIR);

                    if (Cantitate > stocCurent)
                    {
                        string denumireProdus = ctx.Produs.Find(idProdus)?.Denumire ?? $"Produs ID {idProdus}";
                        MessageBox.Show(
                            $"Cantitatea introdusă pentru produsul \"{denumireProdus}\" ({cantitate}) depășește stocul curent ({stocCurent}).",
                            "Stoc insuficient",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return; 
                    }
                }

                ctx.BonTransfer.Add(bonTransfer);
                ctx.SaveChanges();

                foreach (DataGridViewRow rand in produsTransferDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["dataGridViewTextBoxColumn4"].Value;

                    if (produs != null && cantitate != null)
                    {
                        ProdusTransfer pt = new ProdusTransfer
                        {
                            IdBonTransfer = bonTransfer.Id,
                            IdProdus = (int)produs,
                            Cantitate = Convert.ToDecimal(cantitate)
                        };

                        ctx.ProdusTransfer.Add(pt);
                    }
                }

                ctx.SaveChanges();

                bonTransferBindingSource.ResetBindings(false);
               

                produsTransferBindingSource.DataSource = new BindingList<ProdusExpeditie>();
                produsTransferBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaBonTransf lbt = new frmListaBonTransf();
            lbt.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifBonTransf mbt = new frmModifBonTransf();
            mbt.Show();
        }

        private void idDepozitPredatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se afiseaza in dataGridView in coloana 'Produs' doar produsele din depozitul predator selectat
            if (idDepozitPredatorComboBox.SelectedIndex >= 0 && idDepozitPredatorComboBox.SelectedValue is int idDepozit)
            {
                var produseDepozit = (from pg in ctx.ProdusGestionat
                                      where pg.IdDepozit == idDepozit
                                      select pg.Produs).ToList();

                produsBindingSource.DataSource = produseDepozit;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmStocCurent sc = new frmStocCurent();
            sc.Show();
        }
    }
}
