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

namespace GUI.Popups
{
    public partial class HoaDonNhapHang : Form
    {
        NhapDTO nhap = new NhapDTO();
        public HoaDonNhapHang()
        {
            InitializeComponent();
        }

        public HoaDonNhapHang(NhapDTO bill)
        {
            InitializeComponent();

            lbl_nv.Text = bill.staff_name;
            lbl_total.Text = $"{bill.total.ToString()} VND";
            lbl_hoadon.Text = bill.id.ToString();
            lbl_createdAt.Text = bill.createAt.ToShortDateString();
            InitDataGridView();
            this.nhap = bill;
        }

        void InitDataGridView()
        {
            dgv_hoadon.ColumnCount = 3;
            dgv_hoadon.Columns[0].HeaderText = "Tên sản phẩm";
            dgv_hoadon.Columns[1].HeaderText = "Số lượng";
            dgv_hoadon.Columns[2].HeaderText = "Giá";
            LoadDataToDataGridView(NhapHangQLSP.cart);
        }

        void LoadDataToDataGridView(List<spnccDTO> list)
        {
            dgv_hoadon.Rows.Clear();
            dgv_hoadon.Refresh();
            foreach (spnccDTO item in list)
            {
                string[] row = new string[] { item.Name, item.Quantity.ToString(), item.Prices.ToString() };
                dgv_hoadon.Rows.Add(row);

            }
        }
        private void HoaDonNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ReportImportDTO> list = new List<ReportImportDTO>();
            foreach(spnccDTO item in NhapHangQLSP.cart)
            {
                ReportImportDTO rp = new ReportImportDTO();
                rp.Price = item.Prices;
                rp.Qty = item.Quantity;
                rp.Name = item.Name;
                rp.Total = item.Prices * item.Quantity;
                list.Add(rp);
            }

            BillImport bill = new BillImport(nhap,list);
            bill.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
