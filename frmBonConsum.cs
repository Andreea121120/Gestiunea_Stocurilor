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
    public partial class frmBonConsum : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmBonConsum()
        {
            InitializeComponent();
        }
        private void frmBonConsum_Load(object sender, EventArgs e)
        {
            ctx.BonConsum.Load();
            ctx.ProdusConsum.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            idDepozitComboBox.SelectedIndex = -1;
        }

        public int StocCurent(int idProdus, int idDepozit, DateTime data)
        {
            string sql = "SELECT StocCurent FROM dbo.StocCurentTB(@p0, @p1, @p2)";
            return ctx.Database.SqlQuery<int>(sql, idProdus, idDepozit, data).FirstOrDefault();
        }

        private void bonConsumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (idDepozitComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Selectează un depozit!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(numarTextBox.Text))
                {
                    MessageBox.Show("Introdu un număr Bon consum!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nrBC = numarTextBox.Text.Trim();
                if (ctx.BonConsum.Any(bc => bc.Numar == nrBC))
                {
                    MessageBox.Show($"Există deja un bon de consum cu numărul \"{nrBC}\"!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Validate();

                bonConsumBindingSource.EndEdit();
                produsConsumBindingSource.EndEdit();
                depozitBindingSource.EndEdit();
                produsBindingSource.EndEdit();

                bool existaRand = false;

                // Se verifica daca sunt introduse date in toate campurile de pe un rand
                //Nu se salveaza Bonul de consum daca nu este introdus nimic in produsConsumDataGridView
                foreach (DataGridViewRow rand in produsConsumDataGridView.Rows)
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

                BonConsum bonConsum = new BonConsum
                {
                    IdDepozit = (int)idDepozitComboBox.SelectedValue,
                    Numar = numarTextBox.Text,
                    Data = dataDateTimePicker.Value
                };

                foreach (DataGridViewRow rand in produsConsumDataGridView.Rows)
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

                    int idDepozit = (int)idDepozitComboBox.SelectedValue;
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
                        return; // oprește salvarea
                    }
                }

                ctx.BonConsum.Add(bonConsum);
                ctx.SaveChanges();

                foreach (DataGridViewRow rand in produsConsumDataGridView.Rows)
                {
                    if (rand.IsNewRow) continue;

                    var produs = rand.Cells["dataGridViewTextBoxColumn3"].Value;
                    var cantitate = rand.Cells["dataGridViewTextBoxColumn4"].Value;

                    if (produs != null && cantitate != null)
                    {
                        ProdusConsum pc = new ProdusConsum
                        {
                            IdBonConsum = bonConsum.Id,
                            IdProdus = (int)produs,
                            Cantitate = Convert.ToDecimal(cantitate)
                        };

                        ctx.ProdusConsum.Add(pc);
                    }
                }

                ctx.SaveChanges();

                bonConsumBindingSource.ResetBindings(false);

                produsConsumBindingSource.DataSource = new BindingList<ProdusExpeditie>();
                produsConsumBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idDepozitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se afiseaza in dataGridView in coloana 'Produs' doar produsele din depozitul selectat (cu exceptia produselor finite si a marfurilor)
            if (idDepozitComboBox.SelectedIndex >= 0 && idDepozitComboBox.SelectedValue is int idDepozit)
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaBonConsum lbc = new frmListaBonConsum();
            lbc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifBonConsum mbc = new frmModifBonConsum();
            mbc.Show();
        }
    }
}
