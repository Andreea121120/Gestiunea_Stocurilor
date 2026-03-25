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
    public partial class frmRaportBalanta : Form
    {
        BD1Entities1 ctx = new BD1Entities1();
        DateTime dataInceput;
        DateTime dataSfarsit;
        int idDepozit;
        public frmRaportBalanta(DateTime inceput, DateTime sfarsit, int idDepozitSelectat)
        {
            InitializeComponent();
            dataInceput = inceput;
            dataSfarsit = sfarsit;
            idDepozit = idDepozitSelectat;
        }

        private void frmRaportBalanta_Load(object sender, EventArgs e)
        {
            ctx.BalantaStocuri(dataInceput, dataSfarsit, idDepozit).Load();

            var rezultate = ctx.BalantaStocuri(dataInceput, dataSfarsit, idDepozit).ToList();

            var firma = ctx.InfFirma.FirstOrDefault();
            List<InfFirma> listaFirma = new List<InfFirma>();
            if (firma != null)
                listaFirma.Add(firma);

            ReportDataSource rds = new ReportDataSource("DataSet1", rezultate);

            ReportDataSource rdsFirma = new ReportDataSource("DataSetFirma", listaFirma);

            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rdsFirma);


            string numeDepozit = ctx.Depozit
                .Where(d => d.Id == idDepozit)
                .Select(d => d.Denumire)
                .FirstOrDefault() ?? "Necunoscut";

            ReportParameter[] parametri = new ReportParameter[]
            {
                new ReportParameter("data1", dataInceput.ToShortDateString()),
                new ReportParameter("data2", dataSfarsit.ToShortDateString()),
                new ReportParameter("depozit", numeDepozit)
            };

            reportViewer1.LocalReport.SetParameters(parametri);

            this.reportViewer1.RefreshReport();
        }
    }
}
