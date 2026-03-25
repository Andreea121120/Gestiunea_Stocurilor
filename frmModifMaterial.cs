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
    public partial class frmModifMaterial : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        private int idProdus;
        public frmModifMaterial(int idProdus)
        {
            InitializeComponent();
            this.idProdus = idProdus;
        }

        private void frmModifMaterial_Load(object sender, EventArgs e)
        {
            ctx.Material.Where(m => m.IdProdus == idProdus).Load();
            ctx.Produs.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            materialBindingSource.DataSource = ctx.Material.Local.ToBindingList();
        }

     
        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                materialBindingSource.EndEdit();

                foreach (var item in materialBindingSource.List)
                {
                    if (item is Material m)
                    {
                        if (m.PretEstimatMat == null || m.PretEstimatMat <= 0)
                        {
                            string denumireProdus = ctx.Produs.Find(m.IdProdus)?.Denumire ?? $"Produs ID {m.IdProdus}";
                            MessageBox.Show(
                                $"Prețul trebuie completat și să fie mai mare decât zero.","Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ctx.SaveChanges();
                materialBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
