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
    public partial class frmFisaMagazieParam : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmFisaMagazieParam()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null || !(idComboBox.SelectedValue is int))
            {
                MessageBox.Show("Selectează un depozit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idComboBox1.SelectedValue == null || !(idComboBox1.SelectedValue is int))
            {
                MessageBox.Show("Selectează un produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDepozitF = (int)idComboBox.SelectedValue;
            int idProdusF = (int)idComboBox1.SelectedValue;
            DateTime dataInceput = dateTimePicker1.Value.Date;
            DateTime dataSfarsit = dateTimePicker2.Value.Date;

            if (dataInceput > dataSfarsit)
            {
                MessageBox.Show("Data de început nu poate fi mai mare decât data de sfârșit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmRaportFisaMagazie rfm = new frmRaportFisaMagazie(dataInceput, dataSfarsit, idDepozitF, idProdusF);
            rfm.Show();
        }

        private void FormFisaMagazieParam_Load(object sender, EventArgs e)
        {
            ctx.Depozit.Load();
            ctx.Produs.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
        }
    }
}
