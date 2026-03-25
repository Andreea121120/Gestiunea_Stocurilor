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
    public partial class frmBalanataStocuri : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmBalanataStocuri()
        {
            InitializeComponent();
        }

        private void frmBalanataStocuri_Load(object sender, EventArgs e)
        {
            ctx.Depozit.Load();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null || !(idComboBox.SelectedValue is int))
            {
                MessageBox.Show("Selectează un depozit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDepozit = (int)idComboBox.SelectedValue;
            DateTime dataInitiala = dateTimePicker1.Value.Date;
            DateTime dataFinala = dateTimePicker2.Value.Date;

            if (dataInitiala > dataFinala)
            {
                MessageBox.Show("Data de început nu poate fi mai mare decât data de sfârșit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rezultate = ctx.BalantaStocuri(dataInitiala, dataFinala, idDepozit).ToList();
            balantaStocuri_ResultDataGridView.DataSource = rezultate;
        }

        private void balantaStocuri_ResultDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            grid.Rows[e.RowIndex].Cells["Column1"].Value = (e.RowIndex + 1).ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmIstoricTranzactiiProdus isp = new frmIstoricTranzactiiProdus();
            isp.Show();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null || !(idComboBox.SelectedValue is int))
            {
                MessageBox.Show("Selectează un depozit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDepozit = (int)idComboBox.SelectedValue;
            DateTime dataInceput = dateTimePicker1.Value.Date;
            DateTime dataSfarsit = dateTimePicker2.Value.Date;

            if (dataInceput > dataSfarsit)
            {
                MessageBox.Show("Data de început nu poate fi mai mare decât data de sfârșit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmRaportBalanta frmRaport = new frmRaportBalanta(dataInceput, dataSfarsit, idDepozit);
            frmRaport.Show();
        }
    }
}
