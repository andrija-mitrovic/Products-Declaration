using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDeclaration.WinUI
{
    public partial class ReportForm : Form
    {
        private ReportDocument _report = new ReportDocument();
        private string _reportName;
        private DataTable _dt;

        public ReportForm(string reportName, DataTable dt)
        {
            InitializeComponent();
            _reportName = reportName;
            _dt = dt;

            this.Load += ReportForm_Load;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            _report.Load(_reportName);
            _report.SetDataSource(_dt);
            crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            crystalReportViewer.ReportSource = _report;
            crystalReportViewer.Zoom(1);
        }
    }
}
