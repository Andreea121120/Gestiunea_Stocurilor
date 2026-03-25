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
    public partial class frmModifPF : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        private int idProdus;
        public frmModifPF(int idProdus)
        {
            InitializeComponent();
            this.idProdus = idProdus;
        }

        private void frmModifPF_Load(object sender, EventArgs e)
        {
            ctx.ProdusFinit.Where(m => m.IdProdus == idProdus).Load();
            ctx.Produs.Load();

            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            produsFinitBindingSource.DataSource = ctx.ProdusFinit.Local.ToBindingList();
        }

        private void produsFinitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                produsFinitBindingSource.EndEdit();

                foreach (var item in produsFinitBindingSource.List)
                {
                    if (item is ProdusFinit m)
                    {
                        if (m.CostStandard == null || m.CostStandard <= 0)
                        {
                            string denumireProdus = ctx.Produs.Find(m.IdProdus)?.Denumire ?? $"Produs ID {m.IdProdus}";
                            MessageBox.Show(
                                $"Costul standard trebuie completat și să fie mai mare decât zero.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }

                ctx.SaveChanges();
                produsFinitBindingSource.ResetBindings(false);

                MessageBox.Show("Datele au fost salvate!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show($"Datele nu au fost salvate!\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
