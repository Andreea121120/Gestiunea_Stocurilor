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
    public partial class frmRepartizareProdus : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmRepartizareProdus()
        {
            InitializeComponent();
        }

        private void frmRepartizareProdus_Load(object sender, EventArgs e)
        {
            ctx.ProdusGestionat.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();
            ctx.Gestionar.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();
        }

        private void produsGestionatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDepozitComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Selectează un depozit!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (idProdusComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Selectează un produs!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nu se va salva daca produsul selectat exista deja in depozitul selectat
                int idDepozit = (int)idDepozitComboBox.SelectedValue;
                int idProdus = (int)idProdusComboBox.SelectedValue;

                bool exista = ctx.ProdusGestionat.Any(pg => pg.IdDepozit == idDepozit && pg.IdProdus == idProdus);

                if (exista)
                {
                    MessageBox.Show("Acest produs este deja repartizat în depozitul selectat!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(stocInitialTextBox.Text))
                {
                    MessageBox.Show("Stocul inițial nu a fost introdus!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pretTextBox.Text))
                {
                    MessageBox.Show("Prețul nu a fost introdus!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(stocInitialTextBox.Text, out int stocInitial) || stocInitial <= 0)
                {
                    MessageBox.Show("Stocul inițial trebuie să fie un număr întreg mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(pretTextBox.Text, out decimal pret) || pret <= 0)
                {
                    MessageBox.Show("Prețul trebuie să fie un număr mai mare decât zero!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProdusGestionat produsGestionat = new ProdusGestionat
                {
                    IdDepozit = idDepozit,
                    IdProdus = idProdus,
                    StocInitial = stocInitial,
                    Pret = pret
                };

                ctx.ProdusGestionat.Add(produsGestionat);

                this.Validate();
                produsBindingSource.EndEdit();
                produsGestionatBindingSource.EndEdit();
                depozitBindingSource.EndEdit();

                ctx.SaveChanges();

                produsGestionatBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaProduseRepartizate lpr = new frmListaProduseRepartizate();
            lpr.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifProdRep mpr = new frmModifProdRep();
            mpr.Show();
        }

        private void idDepozitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idDepozitComboBox.SelectedValue != null)
            {
                int IdDepozitSelectat = Convert.ToInt32(idDepozitComboBox.SelectedValue);

                Depozit depozitSelectat = ctx.Depozit.Local.FirstOrDefault(d => d.Id == IdDepozitSelectat);
                if (depozitSelectat != null)
                {
                    Gestionar gestionarResponsabil = ctx.Gestionar.Local.FirstOrDefault(g => g.Id == depozitSelectat.IdGestionar);
                    if (gestionarResponsabil != null)
                    {
                        denumireGestionarTextBox.Text = gestionarResponsabil.Nume;
                    }
                    else
                    {
                        denumireGestionarTextBox.Text = "";
                    }
                }
                else
                {
                    denumireGestionarTextBox.Text = "";
                }
            }
        }
    }
}
