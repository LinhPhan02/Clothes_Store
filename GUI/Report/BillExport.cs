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
    public partial class BillExport : Form
    {
        PhieuXuatDTO hoadon = new PhieuXuatDTO();
        List<ReportImportDTO> products = new List<ReportImportDTO>();
        public BillExport()
        {
            InitializeComponent();
        }

        public BillExport(PhieuXuatDTO xuat, List<ReportImportDTO> list)
        {
            InitializeComponent();
            this.hoadon = xuat;
            this.products = list;
        }
        private void BillExport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.ProcessingMode =
      Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.RefreshReport();
            ReportParameter[] parms = new ReportParameter[5];
            parms[0] = new ReportParameter("date", hoadon.CreatedAt.ToString());
            parms[1] = new ReportParameter("nameNv", hoadon.staffName);
            parms[2] = new ReportParameter("sum", hoadon.Total.ToString());
            parms[3] = new ReportParameter("nameKh", hoadon.CustomerName);
            parms[4] = new ReportParameter("IDHD", hoadon.Id.ToString());

            ReportDataSource rds = new ReportDataSource("DataSet1", products);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.LocalReport.SetParameters(parms);

            this.reportViewer1.RefreshReport();
        }
    }
}
