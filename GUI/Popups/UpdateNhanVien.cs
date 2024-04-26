using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.Screens;

namespace GUI.Popups
{
    public partial class UpdateNhanVien : Form
    {
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO(); 
        public UpdateNhanVien(NhanVienDTO nv)
        {
            InitializeComponent();
            txtName.Text = nv.name;
            txtPass.Text = nv.pass;
            txtPhone.Text = nv.phone;

            cboType.DisplayMember = "Text";
            cboType.ValueMember = "Value";
            cboType.Items.Clear();

            cboType.Items.Add(new { Text = "Chọn loại nv", Value = "" });

            List<CategoryStaffsDTO> list = qlnvBLL.LoadCategoryStaff();

            foreach (CategoryStaffsDTO ct in list)
            {
                cboType.Items.Add(new { Text = $"{ct.type}", Value = $"{ct.id}" });
            }

           

            foreach (CategoryStaffsDTO ct in list)
            {
                if(nv.type == Convert.ToInt32(ct.id))
                {
                    cboType.SelectedItem = new { Text = $"{ct.type}", Value = $"{ct.id}" };
                    break;
                }
            }


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
            string cbValue = (cboType.SelectedItem as dynamic).Value;
            if (cbValue == "")
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

        public void Clear()
        {
            txtName.Text = txtPhone.Text = txtPass.Text = cboType.Text = string.Empty;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (Check())
            {
                nv.name = txtName.Text;
                nv.phone = txtPhone.Text;
                nv.pass = txtPass.Text;
                nv.updatedAt = DateTime.Now;
                nv.status = 1;
                nv.type = Convert.ToInt32((cboType.SelectedItem as dynamic).Value);
               
                if (qlnvBLL.Update(nv.phone, nv.pass, nv.name, nv.createdAt, nv.updatedAt, nv.status, nv.type))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                Close();
            }
        }

        private void UpdateNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
