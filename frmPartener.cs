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
    public partial class frmPartener : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmPartener()
        {
            InitializeComponent();
        }
        private void frmPartener_Load(object sender, EventArgs e)
        {
            ctx.Partener.Load();
        }

        private void partenerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                partenerBindingSource.EndEdit();

                if (string.IsNullOrWhiteSpace(cUITextBox.Text) ||
                    string.IsNullOrWhiteSpace(denumireTextBox.Text) ||
                    tipPartenerComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Completează CUI, Denumirea și Tipul Partenerului!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cui = cUITextBox.Text.Trim();
                string tip = tipPartenerComboBox.SelectedItem?.ToString();

                bool existaCUI = ctx.Partener.Any(p => p.CUI == cui && p.TipPartener == tip);

                if (existaCUI)
                {
                    MessageBox.Show($"CUI-ul \"{cui}\" există deja pentru partenerul de tip \"{tip}\"!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Partener partener = new Partener
                {
                    TipPartener = tip,
                    CUI = cui,
                    Denumire = denumireTextBox.Text,
                    Localitate = localitateTextBox.Text,
                    Adresa = adresaTextBox.Text,
                    ContBancar = contBancarTextBox.Text,
                    Telefon = string.IsNullOrWhiteSpace(telefonTextBox.Text) ? (int?)null : int.Parse(telefonTextBox.Text),
                    Mail = mailTextBox.Text
                };

                ctx.Partener.Add(partener);
                ctx.SaveChanges();

                partenerBindingSource.ResetBindings(false);
               
                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            frmListaParteneri lp = new frmListaParteneri();
            lp.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmModifPartener mp = new frmModifPartener();
            mp.Show();
        }
    }
}
