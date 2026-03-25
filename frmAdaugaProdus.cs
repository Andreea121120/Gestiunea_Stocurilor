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
    public partial class frmAdaugaProdus : Form
    {
        BD1Entities1 ctx = new BD1Entities1();

        public frmAdaugaProdus()
        {
            InitializeComponent();
        }

        private void frmAdaugaProdus_Load(object sender, EventArgs e)
        {
            ActualizeazaCampuri();

        }

        private void ActualizeazaCampuri()
        {
            lblPretEstimMat.Visible = ckMaterial.Checked;
            pretEstimatMatTextBox.Visible = ckMaterial.Checked;

            lblPretEstimMP.Visible = ckMP.Checked;
            pretEstimatMPTextBox.Visible = ckMP.Checked;

            lblPretStMf.Visible = ckMarfa.Checked;
            pretStandardMfTextBox.Visible = ckMarfa.Checked;

            lblCostStPF.Visible = ckPF.Checked;
            costStandardTextBox.Visible = ckPF.Checked;
        }

        private void produsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codTextBox.Text) ||
                string.IsNullOrWhiteSpace(denumireTextBox.Text) ||
                unitateDeMasuraComboBox.SelectedItem == null)
            {
                MessageBox.Show("Completează toate câmpurile.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(codTextBox.Text.Trim(), out int cod))
            {
                MessageBox.Show("Codul trebuie să fie un număr.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ctx.Produs.Any(p => p.Cod == cod))
            {
                MessageBox.Show("Codul există deja.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ckMaterial.Checked && !ckMP.Checked && !ckMarfa.Checked && !ckPF.Checked)
            {
                MessageBox.Show("Selectați cel puțin un tip de produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string UM = unitateDeMasuraComboBox.SelectedItem.ToString();
            var produs = new Produs
            {
                Cod = cod,
                Denumire = denumireTextBox.Text.Trim(),
                UnitateDeMasura = UM
            };

            var materiale = new List<object>(); // se stocheaza tipurile de produs in lista temporara
            decimal pret;

            if (ckMaterial.Checked)
            {
                if (string.IsNullOrWhiteSpace(pretEstimatMatTextBox.Text) ||
                    !decimal.TryParse(pretEstimatMatTextBox.Text.Trim(), out pret) || pret <= 0)
                {
                    MessageBox.Show("Prețul estimat pentru Material trebuie să fie un număr mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materiale.Add(new Material { PretEstimatMat = pret });
            }

            if (ckMP.Checked)
            {
                if (string.IsNullOrWhiteSpace(pretEstimatMPTextBox.Text) ||
                    !decimal.TryParse(pretEstimatMPTextBox.Text.Trim(), out pret) || pret <= 0)
                {
                    MessageBox.Show("Prețul estimat pentru Materie Primă trebuie să fie un număr mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materiale.Add(new MateriePrima { PretEstimatMP = pret });
            }

            if (ckMarfa.Checked)
            {
                if (string.IsNullOrWhiteSpace(pretStandardMfTextBox.Text) ||
                    !decimal.TryParse(pretStandardMfTextBox.Text.Trim(), out pret) || pret <= 0)
                {
                    MessageBox.Show("Prețul standard pentru Marfă trebuie să fie un număr mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materiale.Add(new Marfa { PretStandardMf = pret });
            }

            if (ckPF.Checked)
            {
                if (string.IsNullOrWhiteSpace(costStandardTextBox.Text) ||
                    !decimal.TryParse(costStandardTextBox.Text.Trim(), out pret) || pret <= 0)
                {
                    MessageBox.Show("Costul standard pentru Produs Finit trebuie să fie un număr mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materiale.Add(new ProdusFinit { CostStandard = pret });
            }

            try
            {
                ctx.Produs.Add(produs);

                foreach (var m in materiale)
                {
                    switch (m)
                    {
                        case Material mat:
                            mat.Produs = produs;
                            ctx.Material.Add(mat);
                            break;
                        case MateriePrima mp:
                            mp.Produs = produs;
                            ctx.MateriePrima.Add(mp);
                            break;
                        case Marfa mf:
                            mf.Produs = produs;
                            ctx.Marfa.Add(mf);
                            break;
                        case ProdusFinit pf:
                            pf.Produs = produs;
                            ctx.ProdusFinit.Add(pf);
                            break;
                    }
                }

                ctx.SaveChanges();
                MessageBox.Show("Datele au fost salvate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GolireCampuri();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GolireCampuri()
        { 
                codTextBox.Clear();
                denumireTextBox.Clear();

                pretEstimatMatTextBox.Clear();
                pretEstimatMPTextBox.Clear();
                pretStandardMfTextBox.Clear();
                costStandardTextBox.Clear();

                ckMaterial.Checked = false;
                ckMP.Checked = false;
                ckMarfa.Checked = false;
                ckPF.Checked = false;

                materialBindingSource.ResetBindings(false);
                materiePrimaBindingSource.ResetBindings(false);
                marfaBindingSource.ResetBindings(false);
                produsFinitBindingSource.ResetBindings(false);

                ActualizeazaCampuri();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifProdus mf = new frmModifProdus();
            mf.Show();
        }

        private void ckMaterial_CheckedChanged_1(object sender, EventArgs e)
        {
            ActualizeazaCampuri();
        }

        private void ckMP_CheckedChanged(object sender, EventArgs e)
        {
            ActualizeazaCampuri();
        }

        private void ckMarfa_CheckedChanged(object sender, EventArgs e)
        {
            ActualizeazaCampuri();
        }

        private void ckPF_CheckedChanged(object sender, EventArgs e)
        {
            ActualizeazaCampuri();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
