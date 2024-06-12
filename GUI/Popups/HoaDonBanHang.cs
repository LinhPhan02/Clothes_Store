using DTO;
using GUI.Report;
using GUI.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI.Popups
{
    public partial class HoaDonBanHang : Form
    {

        public hoadonDTO bills;
        PhieuXuatDTO hoadon = new PhieuXuatDTO();
        public HoaDonBanHang(PhieuXuatDTO xuat)
        {
           
            InitializeComponent();
            txt_nv.Text = xuat.staffName;
            txt_kh.Text = xuat.CustomerName ;
            txt_idhd.Text = xuat.Id.ToString();
            txt_day.Text = xuat.CreatedAt.ToString("yyyy-MM-dd hh:mm:ss");
            lbl_total.Text = xuat.Total.ToString();
            InitDataGridView();
            this.hoadon = xuat;
        }

       


        void InitDataGridView()
        {
            dgv_hoadon.ColumnCount = 3;
            dgv_hoadon.Columns[0].HeaderText = "Tên sản phẩm";
            dgv_hoadon.Columns[1].HeaderText = "Số lượng";
            dgv_hoadon.Columns[2].HeaderText = "Giá";
            LoadDataToDataGridView(SanPhamBanHang.cart);
        }

        void LoadDataToDataGridView(List<SpQLSPDTO> list) 
        {
            dgv_hoadon.Rows.Clear();
            dgv_hoadon.Refresh();
            foreach(SpQLSPDTO item in list)
            {
                string[] row = new string[] { item.Name, item.Quantity.ToString(), item.Prices.ToString() };
                dgv_hoadon.Rows.Add(row);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ReportImportDTO> list = new List<ReportImportDTO>();
            foreach(SpQLSPDTO item in SanPhamBanHang.cart)
            {
                ReportImportDTO rp = new ReportImportDTO();
                rp.Total = item.Quantity * item.Prices;
                rp.Qty = item.Quantity;
                rp.Price = item.Prices;
                rp.Name = item.Name;
                list.Add(rp);
            }

            BillExport export = new BillExport(hoadon, list);
            export.ShowDialog();
        }

        private void txt_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
    }
}
