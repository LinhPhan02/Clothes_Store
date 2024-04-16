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
    public partial class AddHopDong : Form
    {
        LuongBLL qllBLL = new LuongBLL();
        LuongDTO l = new LuongDTO();
        public AddHopDong()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtMaNhanVien.Text = txtLuong.Text = string.Empty;
        }

        public bool Check()
        {
            TextBox[] text = { txtMaNhanVien, txtLuong };
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

        private void btnAdd_HD_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                // Tạo đối tượng Random để tạo số ngẫu nhiên
                Random random = new Random();
                // Tạo mã hợp đồng
                string maHopDong = "HD" + random.Next(1000, 10000).ToString();

                l.contract_id = maHopDong;
                l.staff_id = txtMaNhanVien.Text;
                l.rangeSalary = txtLuong.Text;
                l.startTime = NgayBatDau.Value.ToString("yyyy-MM-dd");
                l.endTime = NgayKetThuc.Value.ToString("yyyy-MM-dd");

                if (qllBLL.Insert(l.contract_id, l.startTime, l.endTime, l.rangeSalary, l.staff_id))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Clear();
            }
        }
    }
}
