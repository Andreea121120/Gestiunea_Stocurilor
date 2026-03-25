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
    public partial class frmModifMP : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        private int idProdus;
        public frmModifMP(int idProdus)
        {
            InitializeComponent();
            this.idProdus = idProdus;
        }

        private void frmModifMP_Load(object sender, EventArgs e)
        {
            ctx.MateriePrima.Where(m => m.IdProdus == idProdus).Load();
            ctx.Produs.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            materiePrimaBindingSource.DataSource = ctx.MateriePrima.Local.ToBindingList();
        }

        private void materiePrimaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                materiePrimaBindingSource.EndEdit();

                foreach (var item in materiePrimaBindingSource.List)
                {
                    if (item is MateriePrima m)
                    {
                        if (m.PretEstimatMP == null || m.PretEstimatMP <= 0)
                        {
                            string denumireProdus = ctx.Produs.Find(m.IdProdus)?.Denumire ?? $"Produs ID {m.IdProdus}";
                            MessageBox.Show(
                                $"Prețul trebuie completat și să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                ctx.SaveChanges();
                materiePrimaBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
