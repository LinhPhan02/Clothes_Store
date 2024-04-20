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
    public partial class AddKhuyenMai : Form
    {
        public AddKhuyenMai()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string textboxMaKM = txtMaKM.Text;
                string textboxGiamGia = txtGiamGia.Text;
               
                DateTime dayBD = dateTimePicker1.Value;
                DateTime dayKT = dateTimePicker2.Value;

                bool success = KhuyenMaiBLL.Insert(textboxMaKM, textboxGiamGia, dayBD, dayKT);
                if (success)
                {
                    MessageBox.Show("Khuyến mãi mới thêm thành công.");
                }
                else
                {
                    MessageBox.Show("Khuyến mãi chưa hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
