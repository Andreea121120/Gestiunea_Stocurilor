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
using Microsoft.Reporting.WinForms;

namespace Gestiunea_stocurilor
{
    public partial class frmRaportFisaMagazie : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        DateTime dataInceput;
        DateTime dataSfarsit;
        int idDepozitF;
        int idProdusF;
        public frmRaportFisaMagazie(DateTime inceput, DateTime sfarsit, int idDepozitSelectat, int idProdusSelectat)
        {
            InitializeComponent();
            dataInceput = inceput;
            dataSfarsit = sfarsit;
            idDepozitF = idDepozitSelectat;
            idProdusF = idProdusSelectat;
        }

        private void frmFisaMagazie_Load(object sender, EventArgs e)
        {
            ctx.FisaMagazie1(dataInceput, dataSfarsit, idDepozitF, idProdusF).Load();

            var rezultate = ctx.FisaMagazie1(dataInceput, dataSfarsit, idDepozitF, idProdusF).ToList();

            var firma = ctx.InfFirma.FirstOrDefault();
            List<InfFirma> listaFirma = new List<InfFirma>();
            if (firma != null)
                listaFirma.Add(firma);

            ReportDataSource rds = new ReportDataSource("DataSet1", rezultate);

            ReportDataSource rdsFirma = new ReportDataSource("DataSetFirma", listaFirma);

            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsFirma);


            string numeDepozit = ctx.Depozit
                .Where(d => d.Id == idDepozitF)
                .Select(d => d.Denumire)
                .FirstOrDefault() ?? "Necunoscut";

            string numeProdus = ctx.Produs
                .Where(d => d.Id == idProdusF)
                .Select(d => d.Denumire)
                .FirstOrDefault() ?? "Necunoscut";

            ReportParameter[] parametri = new ReportParameter[]
            {
                new ReportParameter("Depozit", numeDepozit),
                new ReportParameter("Produs", numeProdus)
            };

            reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }
    }
}
