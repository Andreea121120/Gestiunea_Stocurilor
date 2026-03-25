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
    public partial class frmListaFacturi : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaFacturi()
        {
            InitializeComponent();
        }

        private void frmListaFacturi_Load(object sender, EventArgs e)
        {
            ctx.Factura.Load();
            ctx.ContinutFactura.Load();
            ctx.Produs.Load();
            ctx.Partener.Load();

            facturaBindingSource.DataSource = ctx.Factura.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            partenerBindingSource.DataSource = ctx.Partener.Local.ToBindingList();
            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue != null)
            {
                int IdSelectat = Convert.ToInt32(idComboBox.SelectedValue);

                // Filtrare dupa numarul de factura selectat
                var continutFiltrat = ctx.ContinutFactura.Local
                    .Where(cf => cf.IdFactura == IdSelectat)
                    .ToList();

                continutFacturaBindingSource.DataSource = continutFiltrat;

                decimal total = continutFiltrat.Sum(cf => cf.Valoare);
                txtTotal.Text = total.ToString("0.00");

                Factura factura = ctx.Factura.Local.FirstOrDefault(f => f.Id == IdSelectat);
                if (factura != null)
                {
                    var client = ctx.Partener.Local.FirstOrDefault(p => p.Id == factura.IdPartenerClient);
                    var furnizor = ctx.Partener.Local.FirstOrDefault(p => p.Id == factura.IdPartenerFurnizor);

                    clientTextBox.Text = client?.Denumire ?? "";
                    furnizorTextBox.Text = furnizor?.Denumire ?? "";

                    // Logica de afișare/ascundere
                    if (client != null && client.TipPartener == "Client")
                    {
                        lblClient.Visible = true;
                        clientTextBox.Visible = true;
                    }
                    else
                    {
                        lblClient.Visible = false;
                        clientTextBox.Visible = false;
                    }

                    if (furnizor != null && furnizor.TipPartener == "Furnizor")
                    {
                        lblFurnizor.Visible = true;
                        furnizorTextBox.Visible = true;
                    }
                    else
                    {
                        lblFurnizor.Visible = false;
                        furnizorTextBox.Visible = false;
                    }
                }
            }
        }
    }
}
