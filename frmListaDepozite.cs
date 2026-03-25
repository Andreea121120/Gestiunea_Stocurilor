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
    public partial class frmListaDepozite : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaDepozite()
        {
            InitializeComponent();
        }

        private void frmListaDepozite_Load(object sender, EventArgs e)
        {
            ctx.Depozit.Load();
            ctx.Gestionar.Load();

            depozitBindingSource.DataSource = ctx.Depozit.Local.ToBindingList();
            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();
        }
    }
}
