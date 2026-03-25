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
    public partial class frmStocCurent : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmStocCurent()
        {
            InitializeComponent();
        }

        private void frmStocCurent_Load(object sender, EventArgs e)
        {
            ctx.Produs.Load();
            ctx.Depozit.Load();
            
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null || idComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Selectează un produs și un depozit.");
                return;
            }

            int idProdus = Convert.ToInt32(idComboBox.SelectedValue);
            int idDepozit = Convert.ToInt32(idComboBox1.SelectedValue);
            DateTime data = dateTimePicker1.Value.Date;

            try
            {
                var rezultat = ctx.StocCurentTB(idProdus, idDepozit, data).FirstOrDefault();

                if (rezultat.HasValue)
                {
                    if (rezultat.Value < 0)
                        stocCurentTextBox.Text = "0";
                    else
                        stocCurentTextBox.Text = rezultat.Value.ToString();
                }
                else
                {
                    stocCurentTextBox.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la interogare: " + ex.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var rezultat = MessageBox.Show("Ești sigur că dorești să actualizezi stocul inițial și prețul pentru toate produsele?","Confirmare actualizare",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    ctx.Database.ExecuteSqlCommand("EXEC ActualizeazaStocInitialSiPret");

                    MessageBox.Show("Actualizarea s-a realizat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la executarea procedurii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
