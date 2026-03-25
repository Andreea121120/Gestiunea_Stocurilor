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
    public partial class frmDepozit : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmDepozit()
        {
            InitializeComponent();
        }

        private void frmDepozit_Load(object sender, EventArgs e)
        {
            ctx.Gestionar.Load();
            ctx.Depozit.Load();

            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();
            idGestionarComboBox.SelectedIndex = -1;
        }

        private void depozitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = codTextBox.Text.Trim();
                string denumire = denumireTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(cod) || string.IsNullOrWhiteSpace(denumire))
                {
                    MessageBox.Show("Completează câmpurile Cod și Denumire înainte de a salva.", "Câmpuri obligatorii", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool codExista = ctx.Depozit.Any(d => d.Cod == cod);

                if (codExista)
                {
                    MessageBox.Show("Codul introdus există deja. Te rog să alegi un cod unic.", "Cod duplicat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Depozit depozit = new Depozit
                {
                    Cod = codTextBox.Text,
                    Denumire = denumireTextBox.Text,
                    Adresa = adresaTextBox.Text,
                    IdGestionar = idGestionarComboBox.SelectedValue != null ? (int)idGestionarComboBox.SelectedValue : (int?)null // Permite salvarea unui depozit fara sa aleaga un gestionar
                };

                ctx.Depozit.Add(depozit);

                this.Validate();

                depozitBindingSource.EndEdit();
                gestionarBindingSource.EndEdit();

                ctx.SaveChanges();

                depozitBindingSource.ResetBindings(false);
                gestionarBindingSource.ResetBindings(false);

                idGestionarComboBox.SelectedIndex = -1;

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaDepozite ld = new frmListaDepozite();
            ld.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmModificareDepozit md = new frmModificareDepozit();
            md.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRepartizareProdus rp = new frmRepartizareProdus();
            rp.Show();
        }
    }
}
