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
    public partial class frmAdaugaProdusCategorie : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmAdaugaProdusCategorie()
        {
            InitializeComponent();
        }

        private void frmAdaugaProdusCategorie_Load(object sender, EventArgs e)
        {
            idComboBox.DataSource = ctx.Produs.ToList();
            ActualizeazaCampuri();
        }

        private void ckMaterial_CheckedChanged(object sender, EventArgs e)
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

        private void produsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null)
            {
                MessageBox.Show("Selectează un produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ckMaterial.Checked && !ckMP.Checked && !ckMarfa.Checked && !ckPF.Checked)
            {
                MessageBox.Show("Selectează cel puțin un tip de produs bifând una dintre căsuțe.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProdus = (int)idComboBox.SelectedValue;
            bool tipValid = false;

            // Material
            if (ckMaterial.Checked)
            {
                var exista = ctx.Material.FirstOrDefault(m => m.IdProdus == idProdus);
                if (exista != null)
                {
                    MessageBox.Show("Produsul este deja definit ca Material.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(pretEstimatMatTextBox.Text))
                    {
                        MessageBox.Show("Introduceți prețul estimat pentru Material.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(pretEstimatMatTextBox.Text, out decimal pret) || pret <= 0)
                    {
                        MessageBox.Show("Prețul estimat pentru Material trebuie să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ctx.Material.Add(new Material
                    {
                        IdProdus = idProdus,
                        PretEstimatMat = pret
                    });
                    tipValid = true;
                }
            }

            // Materie Prima
            if (ckMP.Checked)
            {
                var exista = ctx.MateriePrima.FirstOrDefault(mp => mp.IdProdus == idProdus);
                if (exista != null)
                {
                    MessageBox.Show("Produsul este deja definit ca Materie Primă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(string.IsNullOrWhiteSpace(pretEstimatMPTextBox.Text))
                    {
                        MessageBox.Show("Introduceți prețul estimat pentru Materie Primă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(pretEstimatMPTextBox.Text, out decimal pret) || pret <= 0)
                    {
                        MessageBox.Show("Prețul estimat pentru Materie Primă trebuie să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ctx.MateriePrima.Add(new MateriePrima
                    {
                        IdProdus = idProdus,
                        PretEstimatMP = pret
                    });
                    tipValid = true;
                }
            }

            // Marfa
            if (ckMarfa.Checked)
            {
                var exista = ctx.Marfa.FirstOrDefault(mf => mf.IdProdus == idProdus);
                if (exista != null)
                {
                    MessageBox.Show("Produsul este deja definit ca Marfă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(pretStandardMfTextBox.Text))
                    {
                        MessageBox.Show("Introduceți prețul standard pentru Marfă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(pretStandardMfTextBox.Text, out decimal pret) || pret <= 0)
                    {
                        MessageBox.Show("Prețul standard pentru Marfă trebuie să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ctx.Marfa.Add(new Marfa
                    {
                        IdProdus = idProdus,
                        PretStandardMf = pret
                    });
                    tipValid = true;
                }
            }

            // Produs Finit
            if (ckPF.Checked)
            {
                var exista = ctx.ProdusFinit.FirstOrDefault(pf => pf.IdProdus == idProdus);
                if (exista != null)
                {
                    MessageBox.Show("Produsul este deja definit ca Produs Finit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(costStandardTextBox.Text))
                    {
                        MessageBox.Show("Introduceți costul standard pentru Produs Finit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(costStandardTextBox.Text, out decimal cost) || cost <= 0)
                    {
                        MessageBox.Show("Costul standard pentru Produs Finit trebuie să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ctx.ProdusFinit.Add(new ProdusFinit
                    {
                        IdProdus = idProdus,
                        CostStandard = cost
                    });
                    tipValid = true;
                }
            }

            if (!tipValid)
                return;

            try
            {
                ctx.SaveChanges();
                MessageBox.Show("Categoria de produs a fost adăugată!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvare!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaCampuri()
        {
            lblPretEstimMat.Visible = pretEstimatMatTextBox.Visible = ckMaterial.Checked;
            lblPretEstimMP.Visible = pretEstimatMPTextBox.Visible = ckMP.Checked;
            lblPretStMf.Visible = pretStandardMfTextBox.Visible = ckMarfa.Checked;
            lblCostStPF.Visible = costStandardTextBox.Visible = ckPF.Checked;
        }

    }
}
