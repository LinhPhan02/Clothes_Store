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
    public partial class BanHang : UserControl
    {
        public BanHang()
        {
            InitializeComponent();
            sanPhamBanHang1.BringToFront();
            sanPhamBanHang1.resetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamBanHang1.BringToFront();
            sanPhamBanHang1.resetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gioHangBanHang2.BringToFront();
            gioHangBanHang2.resetData();
        }

        private void sanPhamBanHang1_Load(object sender, EventArgs e)
        {

        }

        private void sanPhamBanHang1_Load_1(object sender, EventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
