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
    public partial class frmListaParteneri : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaParteneri()
        {
            InitializeComponent();
        }

        private void frmListaParteneri_Load(object sender, EventArgs e)
        {
            ctx.Partener.Load();
            partenerBindingSource.DataSource = ctx.Partener.Local.ToBindingList();

            rbTp.Checked = true;
        }

        private void FiltreazaParteneri()
        {
            if (rbCl.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local
                    .Where(p => p.TipPartener == "Client")
                    .ToList();
            }
            else if (rbFz.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local
                    .Where(p => p.TipPartener == "Furnizor")
                    .ToList();
            }
            else if (rbTp.Checked)
            {
                partenerBindingSource.DataSource = ctx.Partener.Local.ToList();
            }
        }

        private void rbCl_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }

        private void rbFz_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }

        private void rbTp_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaParteneri();
        }
    }
}
