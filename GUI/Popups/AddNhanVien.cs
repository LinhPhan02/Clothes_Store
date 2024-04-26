using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BLL;

namespace GUI.Popups
{
    public partial class AddNhanVien : Form
    {
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO();
        public AddNhanVien()
        {
            InitializeComponent();

            cboType.DisplayMember = "Text";
            cboType.ValueMember = "Value";
            cboType.Items.Clear();
            cboType.Items.Add(new { Text = "Chọn loại nv", Value = "" });

            List<CategoryStaffsDTO> list = qlnvBLL.LoadCategoryStaff();

            foreach(CategoryStaffsDTO ct in list)
            {
                cboType.Items.Add(new {Text = $"{ct.type}", Value = $"{ct.id}"});
            }
            cboType.SelectedIndex = 0;
        }

        public void Clear()
        {
            txtName.Text = txtPhone.Text = txtPass.Text = string.Empty;
            cboType.SelectedIndex = 0;
        }

        public bool Check()
        {
            TextBox[] text = { txtName, txtPhone, txtPass };
            foreach (TextBox txt in text)
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");
                    txt.Focus();
                    return false;
                }
            }

            string cbTypeValue = (cboType.SelectedItem as dynamic).Value;

            if(cbTypeValue == "")
            {
                MessageBox.Show("Cần chọn loại nhân viên!");
                return false;
            }
            //Kiểm tra định dạng số điện thoại
            if (text[1].Text != null)
            {
                if(!BLL.Class1.IsValidPhone(text[1].Text))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại số điện thoại!");
                    return false;
                }
            }
            
            return true;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                nv.name = txtName.Text;
                nv.phone = txtPhone.Text;
                nv.pass = txtPass.Text;
                nv.createdAt = DateTime.Now;
                nv.updatedAt = DateTime.Now;
                nv.status = 1;
                nv.type = Convert.ToInt32((cboType.SelectedItem as dynamic).Value);


                if (qlnvBLL.Insert(nv.phone, nv.pass, nv.name, nv.createdAt, nv.updatedAt, nv.status, nv.type))
                {
                    MessageBox.Show("Thêm thành công!");
                }
                Close();
            }
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
