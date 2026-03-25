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
    public partial class frmModificareDepozit : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModificareDepozit()
        {
            InitializeComponent();
        }

        private void frmModificareDepozit_Load(object sender, EventArgs e)
        {
            ctx.Depozit.Load();
            ctx.Gestionar.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();

        }

        private void depozitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                depozitBindingSource.EndEdit();
                gestionarBindingSource.EndEdit();
                ctx.SaveChanges();
                depozitBindingSource.ResetBindings(false);
                gestionarBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depozitDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var grid = (DataGridView)sender;

            var currentRow = grid.Rows[e.RowIndex];
            var cod = currentRow.Cells["dataGridViewTextBoxColumn3"];

            if (cod.Value == null || string.IsNullOrWhiteSpace(cod.Value.ToString()))
                return;

            string codCurent = cod.Value.ToString().Trim();

            // Preia ID-ul curent (daca exista un ID în model) – ignora randul actual din comparatie
            int? idCurent = null;
            if (currentRow.DataBoundItem is Depozit depozitCurent)
                idCurent = depozitCurent.Id;

            // Verifia daca codul este deja folosit în alt rând
            var codDuplicat = ctx.Depozit.Local.Any(d =>
                d.Cod == codCurent &&
                d.Id != idCurent);

            if (codDuplicat)
            {
                grid.Rows[e.RowIndex].ErrorText = $"Codul '{codCurent}' este deja folosit!";
                cod.ErrorText = "Cod duplicat";

                e.Cancel = true;
            }
            else
            {
                // Curata erorile
                grid.Rows[e.RowIndex].ErrorText = "";
                cod.ErrorText = "";
            }
        }
    }
}
