using BLL;
using DTO;
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
    public partial class BanHangHasTK : Form
    {
        public KhachHangDTO kh;
        public bool flag = false;
        public BanHangHasTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            kh = BanHangBLL.GetCustomer(txt_search.Text);

            if(kh != null && kh.Phone != null)
            {
                lbl_namekh.Text = kh.Name;
                lbl_total.Text = kh.ToTal.ToString();
            }

        }

        private void BanHangHasTK_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(kh != null && kh.Phone != "")
            {
                this.Hide();
                flag = true;

            }
        }
    }
}
