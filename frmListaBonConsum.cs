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
    public partial class frmListaBonConsum : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaBonConsum()
        {
            InitializeComponent();
        }

        private void frmListaBonConsum_Load(object sender, EventArgs e)
        {
            ctx.BonConsum.Load();
            ctx.ProdusConsum.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();


            bonConsumBindingSource.DataSource = ctx.BonConsum.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
          
            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue != null)
            {
                int IdSelectat = Convert.ToInt32(idComboBox.SelectedValue);

                // Filtrare dupa numarul de bon selectat
                var continutFiltrat = ctx.ProdusConsum.Local
                    .Where(pc => pc.IdBonConsum == IdSelectat)
                    .ToList();

                produsConsumBindingSource.DataSource = continutFiltrat;

                //Afisare denumire depozit in functie de numar bon selectat
                BonConsum BcSelectat = ctx.BonConsum.Local.FirstOrDefault(bc => bc.Id == IdSelectat);
                if (BcSelectat != null)
                {
                    Depozit depozit = ctx.Depozit.Local.FirstOrDefault(d => d.Id == BcSelectat.IdDepozit);
                    if (depozit != null)
                    {
                        idDepozitTextBox.Text = depozit.Denumire;
                    }
                    else
                    {
                        idDepozitTextBox.Text = "";
                    }
                }
            }
        }
    }
}
