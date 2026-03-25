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
    public partial class frmIstoricTranzactiiProdus : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmIstoricTranzactiiProdus()
        {
            InitializeComponent();
        }

        private void frmIstoricTranzactiiProdus_Load(object sender, EventArgs e)
        {
            ctx.Depozit.Load();
            ctx.Produs.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue == null || !(idComboBox.SelectedValue is int ))
            {
                MessageBox.Show("Selectează un depozit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idComboBox1.SelectedValue == null || !(idComboBox1.SelectedValue is int))
            {
                MessageBox.Show("Selectează un produs.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDepozit = (int)idComboBox.SelectedValue;
            int idProdus = (int)idComboBox1.SelectedValue;
            DateTime dataInitiala = dateTimePicker1.Value.Date;
            DateTime dataFinala = dateTimePicker2.Value.Date;

            if (dataInitiala > dataFinala)
            {
                MessageBox.Show("Data de început nu poate fi mai mare decât data de sfârșit.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rezultate = ctx.BalantaProdusDetaliat(dataInitiala, dataFinala, idDepozit, idProdus).ToList();
            balantaProdusDetaliat_ResultDataGridView.DataSource = rezultate;

            decimal totalIntrari = rezultate
                .Where(r => r.Sens == "Intrare")
                .Sum(r => r.Valoare ?? 0);

            decimal totalIesiri = rezultate
                .Where(r => r.Sens == "Iesire")
                .Sum(r => r.Valoare ?? 0);

            txtTotalIntrari.Text = totalIntrari.ToString("N2");
            txtTotalIesiri.Text = totalIesiri.ToString("N2");
        }

        private void balantaProdusDetaliat_ResultDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            grid.Rows[e.RowIndex].Cells["Column1"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
