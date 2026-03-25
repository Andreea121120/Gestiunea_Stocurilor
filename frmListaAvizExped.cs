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
    public partial class frmListaAvizExped : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaAvizExped()
        {
            InitializeComponent();
        }

        private void frmListaAvizExped_Load(object sender, EventArgs e)
        {
            ctx.AvizExpeditie.Load();
            ctx.ProdusExpeditie.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();
            ctx.Factura.Load();

            avizExpeditieBindingSource.DataSource = ctx.AvizExpeditie.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();


            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue != null)
            {
                int IdSelectat = Convert.ToInt32(idComboBox.SelectedValue);

                // Filtrare dupa numarul de aviz selectat
                var continutFiltrat = ctx.ProdusExpeditie.Local
                    .Where(pe => pe.IdAvizExpeditie == IdSelectat)
                    .ToList();

                produsExpeditieBindingSource.DataSource = continutFiltrat;

                //Afisare denumire depozit in functie de numar aviz selectat
                AvizExpeditie AESelectat = ctx.AvizExpeditie.Local.FirstOrDefault(ae => ae.Id == IdSelectat);
                if (AESelectat != null)
                {
                    Depozit depozit = ctx.Depozit.Local.FirstOrDefault(d => d.Id == AESelectat.IdDepozit);
                    if (depozit != null)
                    {
                        idDepozitTextBox.Text = depozit.Denumire;
                    }
                    else
                    {
                        idDepozitTextBox.Text = "";
                    }

                    Factura factura = ctx.Factura.Local.FirstOrDefault(f => f.Id == AESelectat.IdFactura);
                    if (factura != null)
                    {
                        idFacturaTextBox.Text = factura.Numar.ToString();
                    }
                    else
                    {
                        idFacturaTextBox.Text = "";
                    }
                }
            }
        }
    }
}
