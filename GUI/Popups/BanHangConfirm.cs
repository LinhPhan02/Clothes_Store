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
    public partial class BanHangConfirm : Form
    {
        public bool flag = false;
        public KhachHangDTO kh = new KhachHangDTO();
        public BanHangConfirm()
        {
            InitializeComponent();
        }

        private void BanHangConfirm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" && txt_phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }

            kh = new KhachHangDTO();
            kh.ToTal = 0;
            kh.Phone = txt_phone.Text;
            kh.Name = txt_name.Text;
            kh.Status = 1;
            kh.CreatedAt = DateTime.Now;
            kh.UpdatedAt = DateTime.Now;
            KhachHangBLL khBLL = new KhachHangBLL();

            bool check = khBLL.InsertKH(kh);

            if (check)
            {
                this.Hide();
                flag = true;
            }
            else
            {
                MessageBox.Show("<Error> Số điện thoại đã được đăng ký");
            }

        }
    }
}
