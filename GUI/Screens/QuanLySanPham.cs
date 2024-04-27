using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class QuanLySanPham : UserControl
    {
        public QuanLySanPham()
        {
            InitializeComponent();
            sanPhamQLSP1.BringToFront();
            sanPhamQLSP1.resetData();
            if (Login._checkUrlMatch("thanhtoangiohang:QLSP"))
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamQLSP1.BringToFront();
            sanPhamQLSP1.resetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhapHangQLSP1.BringToFront();
            nhapHangQLSP1.resetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gioHangQLSP1.BringToFront();
            gioHangQLSP1.resetData();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {

        }

        private void gioHangQLSP1_Load(object sender, EventArgs e)
        {

        }
    }
}
