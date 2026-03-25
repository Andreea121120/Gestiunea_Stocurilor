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
    public partial class frmListaProduseRepartizate : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaProduseRepartizate()
        {
            InitializeComponent();
        }

        private void frmListaProduseRepartizate_Load(object sender, EventArgs e)
        {
            ctx.ProdusGestionat.Load();
            ctx.Produs.Load();
            ctx.Depozit.Load();
            ctx.Gestionar.Load();

            produsGestionatBindingSource.DataSource = ctx.ProdusGestionat.Local.ToBindingList();
            produsBindingSource.DataSource = ctx.Produs.Local.ToBindingList();
            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();

            idComboBox.SelectedIndex = -1;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idComboBox.SelectedValue != null)
            {
                int idDepozitSelectat = (int)idComboBox.SelectedValue;

                var produseFiltrate = ctx.ProdusGestionat.Local
                    .Where(p => p.IdDepozit == idDepozitSelectat)
                    .ToList();

                produsGestionatBindingSource.DataSource = produseFiltrate;


                Depozit depozitSelectat = ctx.Depozit.Local.FirstOrDefault(d => d.Id == idDepozitSelectat); 
                if (depozitSelectat != null && depozitSelectat.IdGestionar.HasValue)
                {
                    Gestionar gestionar = ctx.Gestionar.Local.FirstOrDefault(g => g.Id == depozitSelectat.IdGestionar.Value);
                    if (gestionar != null)
                    {
                        numeGestionarTextBox.Text = gestionar.Nume;
                    }
                    else
                    {
                        numeGestionarTextBox.Text = " ";
                    }
                }
                else
                {
                    numeGestionarTextBox.Text = " ";
                }
            }
        } 
    }
}

