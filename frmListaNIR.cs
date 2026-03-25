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
    public partial class frmListaNIR : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaNIR()
        {
            InitializeComponent();
        }

        private void frmListaNIR_Load(object sender, EventArgs e)
        {
            ctx.NIR.Load();
            ctx.ContinutNIR.Load();
            ctx.ContinutFactura.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();
            ctx.Factura.Load();

            nIRBindingSource.DataSource = ctx.NIR.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();

            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue != null)
            {
                int selectedIdNIR = Convert.ToInt32(idComboBox.SelectedValue);

                // Filtrare dupa numarul de NIR selectat
                var continutFiltrat = ctx.ContinutNIR.Local
                    .Where(c => c.IdNIR == selectedIdNIR)
                    .ToList();

                continutNIRBindingSource.DataSource = continutFiltrat;

                //Afisare denumire depozit si numarul de factura in functie de numar NIR selectat
                NIR nirSelectat = ctx.NIR.Local.FirstOrDefault(n => n.Id == selectedIdNIR);
                if (nirSelectat != null)
                {
                    Depozit depozit = ctx.Depozit.Local.FirstOrDefault(d => d.Id == nirSelectat.IdDepozit);
                    if (depozit != null)
                    {
                        idDepozitTextBox.Text = depozit.Denumire;
                    }
                    else
                    {
                        idDepozitTextBox.Text = "";
                    }

                    Factura factura = ctx.Factura.Local.FirstOrDefault(f => f.Id == nirSelectat.IdFactura);
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
