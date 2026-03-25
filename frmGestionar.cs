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
    public partial class frmGestionar : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmGestionar()
        {
            InitializeComponent();
        }

        private void frmGestionar_Load(object sender, EventArgs e)
        {
            ctx.Gestionar.Load();
        }

        private void gestionarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                string cnp = cNPTextBox.Text.Trim();
                if (cnp.Length != 13 || !cnp.All(char.IsDigit))
                {
                    MessageBox.Show("CNP-ul trebuie să conțină exact 13 cifre.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Gestionar existaG = ctx.Gestionar.FirstOrDefault(g => g.CNP == cnp);
                if (existaG != null)
                {
                    MessageBox.Show("Există deja un gestionar cu acest CNP.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(numeTextBox.Text) || string.IsNullOrWhiteSpace(prenumeTextBox.Text))
                {
                    MessageBox.Show("Toate câmpurile trebuie completate.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Gestionar gestionar = new Gestionar
                {
                    CNP = cnp,
                    Nume = numeTextBox.Text,
                    Prenume = prenumeTextBox.Text
                };

                ctx.Gestionar.Add(gestionar);

                this.Validate();

                gestionarBindingSource.EndEdit();

                ctx.SaveChanges();

                gestionarBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaGestionari lg = new frmListaGestionari();
            lg.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifGestionar mg = new frmModifGestionar();
            mg.Show();
        }
    }
   
}
