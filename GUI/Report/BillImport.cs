using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class BillImport : Form
    {
        NhapDTO hoadon = new NhapDTO();
        List<ReportImportDTO> products = new List<ReportImportDTO>();
        public BillImport()
        {
            InitializeComponent();
        }

        public BillImport(NhapDTO nhap, List<ReportImportDTO> list)
        {
            InitializeComponent();
            this.hoadon = nhap;
            this.products = list;
        }

        private void BillImport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode =
    Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.RefreshReport();
            ReportParameter[] parms = new ReportParameter[5];
            parms[0] = new ReportParameter("date", hoadon.createAt.ToString());
            parms[1] = new ReportParameter("nameNv", hoadon.staff_name);
            parms[2] = new ReportParameter("sum", hoadon.total.ToString());
            parms[3] = new ReportParameter("nameNcc", hoadon.producer_name.ToString());
            parms[4] = new ReportParameter("IDHD", hoadon.id.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", products);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.LocalReport.SetParameters(parms);

            this.reportViewer1.RefreshReport();

        }
    }
}
