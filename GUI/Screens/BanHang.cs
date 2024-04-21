using BLL;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamBanHang1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gioHangBanHang1.BringToFront();
        }
    }
}
