using Microsoft.Reporting.WinForms;
using SampleDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class frmPrint : Form
    {
        SampleDbContext db = new SampleDbContext("sampleDb");
        string sortBy;
        public frmPrint(string received)
        {
            InitializeComponent();
            sortBy = received;
        }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AccountApplication.ReportAccountChart.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            if (sortBy == "ChinaCode")
            {
                rds.Value = db.AccCharts.OrderBy(x => x.aChinaCode);
            }
            else if(sortBy == "HKCode")
            {
                rds.Value = db.AccCharts.OrderBy(x => x.aHKCode);
            }
            this.reportViewer.LocalReport.DataSources.Add(rds);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameterDate", "Date : " + DateTime.Now.ToString("dd/MM/yyyy")));
            reportParameters.Add(new ReportParameter("ReportParameterTime", "Time : " + DateTime.Now.ToString("hh:mm")));
            this.reportViewer.LocalReport.SetParameters(reportParameters);
            this.reportViewer.RefreshReport();
        }
    }
}
