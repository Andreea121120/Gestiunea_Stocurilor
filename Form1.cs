using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiunea_stocurilor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adaugaProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdaugaProdus ap = new frmAdaugaProdus();
            ap.Show();
        }

        private void listaProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifProdus mp = new frmModifProdus();
            mp.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionar g = new frmGestionar();
            g.Show();
        }

        private void depoziteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepozit d = new frmDepozit();
            d.Show();
        }

        private void gestiuneProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receptieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNIR nir = new frmNIR();
            nir.Show();
        }

        private void avizExpeditieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvizExped ae = new frmAvizExped();
            ae.Show();
        }

        private void bonTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBonTransfer bt = new frmBonTransfer();
            bt.Show();
        }

        private void bonConusmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBonConsum bc = new frmBonConsum();
            bc.Show();
        }

        private void parteneriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPartener p = new frmPartener();
            p.Show();
        }

        private void comenziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura f = new frmFactura();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStocCurent sc = new frmStocCurent();
            sc.Show();
        }

        private void repartizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepartizareProdus rp = new frmRepartizareProdus();
            rp.Show();
        }

        private void parteneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartener p = new frmPartener();
            p.Show();
        }

        private void balantaStocurilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalanataStocuri bs = new frmBalanataStocuri();
            bs.Show();
        }

        private void intrariIesiriProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIstoricTranzactiiProdus isp = new frmIstoricTranzactiiProdus();
            isp.Show();
        }

        private void fisaDeMagazieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFisaMagazieParam fm = new frmFisaMagazieParam();
            fm.Show();
        }
    }
}
