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
    public partial class frmListaBonTransf : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaBonTransf()
        {
            InitializeComponent();
        }

        private void frmListaBonTransf_Load(object sender, EventArgs e)
        {
            ctx.BonTransfer.Load();
            ctx.ProdusTransfer.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();


            bonTransferBindingSource.DataSource = ctx.BonTransfer.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();

            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (idComboBox.SelectedValue != null)
            {
                int IdSelectat = Convert.ToInt32(idComboBox.SelectedValue);

                // Filtrare dupa numarul de bon selectat
                var continutFiltrat = ctx.ProdusTransfer.Local
                    .Where(pt => pt.IdBonTransfer == IdSelectat)
                    .ToList();

                produsTransferBindingSource.DataSource = continutFiltrat;

                //Afisare denumire depozit in functie de numar bon selectat
                BonTransfer BtSelectat = ctx.BonTransfer.Local.FirstOrDefault(bt => bt.Id == IdSelectat);
                if (BtSelectat != null)
                {
                    Depozit depozitPredator = ctx.Depozit.Local.FirstOrDefault(d => d.Id == BtSelectat.IdDepozitPredator);
                    if (depozitPredator != null)
                    {
                        idDepozitPredatorTextBox.Text = depozitPredator.Denumire;
                    }
                    else
                    {
                        idDepozitPredatorTextBox.Text = "";
                    }

                    Depozit depozitPrimitor = ctx.Depozit.Local.FirstOrDefault(d => d.Id == BtSelectat.IdDepozitPrimitor);
                    if (depozitPrimitor != null)
                    {
                        idDepozitPrimitorTextBox.Text = depozitPrimitor.Denumire;
                    }
                    else
                    {
                        idDepozitPrimitorTextBox.Text = "";
                    }
                }
            }
        }
    }
}
