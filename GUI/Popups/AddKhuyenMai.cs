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
        KhuyenMaiBLL qlkmBLL = new KhuyenMaiBLL();
        KhuyenMaiDTO km = new KhuyenMaiDTO();
        public AddKhuyenMai()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtTenKM.Text = txtGiamGia.Text = string.Empty;
        }

        public bool Check()
        {
            TextBox[] text = { txtTenKM, txtGiamGia };
            foreach (TextBox txt in text)
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");
                    txt.Focus();
                    return false;
                }
            }

            return true;
        }
        private void btn_AddKM_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                // Tạo đối tượng Random để tạo số ngẫu nhiên
                Random random = new Random();
                // Tạo mã hợp đồng
                string maKhuyenMai = "KM" + random.Next(1000, 10000).ToString();

                km.discount_id = maKhuyenMai;
                km.discount_name = txtTenKM.Text;
                km.discount_amount = Int32.Parse(txtGiamGia.Text);
                km.start_day = BatDauKM.Value.ToString("MM-dd-yyyy");
                km.end_day = KetThucKM.Value.ToString("MM-dd-yyyy");
                km.status = 1;

                if (qlkmBLL.Insert(km.discount_id, km.discount_name, km.start_day, km.end_day, km.discount_amount, km.status))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Close();
            }
        }
    }
}
