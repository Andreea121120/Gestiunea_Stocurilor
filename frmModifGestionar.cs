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
    public partial class frmModifGestionar : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmModifGestionar()
        {
            InitializeComponent();
        }

        private void frmModifGestionar_Load(object sender, EventArgs e)
        {
            ctx.Gestionar.Load();

            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();
        }

        private void gestionarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                gestionarBindingSource.EndEdit();

                ctx.SaveChanges();
                gestionarBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gestionarDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
                return;

            var currentRow = grid.Rows[e.RowIndex];

            if (currentRow.IsNewRow)
                return;

            // Verifică dacă BindingSource are element pentru indexul respectiv
            if (e.RowIndex >= gestionarBindingSource.Count)
                return;

            var gestionarCurent = gestionarBindingSource[e.RowIndex] as Gestionar;
            if (gestionarCurent == null)
                return;

            var cnpCell = currentRow.Cells["dataGridViewTextBoxColumn2"];
            string cnpCurent = cnpCell?.Value?.ToString()?.Trim();

            cnpCell.ErrorText = "";

            if (string.IsNullOrEmpty(cnpCurent))
            {
                cnpCell.ErrorText = "CNP este obligatoriu!";
                MessageBox.Show("CNP este obligatoriu!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            if (cnpCurent.Length != 13 || !cnpCurent.All(char.IsDigit))
            {
                cnpCell.ErrorText = "CNP trebuie să conțină exact 13 cifre!";
                MessageBox.Show("CNP trebuie să conțină exact 13 cifre!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            int idCurent = gestionarCurent.Id;

            bool duplicat = ctx.Gestionar.Local.Any(g =>
                g.CNP == cnpCurent &&
                g.Id != idCurent);

            if (duplicat)
            {
                cnpCell.ErrorText = $"CNP '{cnpCurent}' deja utilizat!";
                MessageBox.Show($"CNP '{cnpCurent}' deja utilizat!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}
