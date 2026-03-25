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
    public partial class frmListaGestionari : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        public frmListaGestionari()
        {
            InitializeComponent();
        }

        private void frmListaGestionari_Load(object sender, EventArgs e)
        {
            ctx.Gestionar.Load();
            gestionarBindingSource.DataSource = ctx.Gestionar.Local.ToBindingList();
        }
    }
}
