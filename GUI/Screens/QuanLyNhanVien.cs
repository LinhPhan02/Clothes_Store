using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Popups;
using BLL;
using DTO;

namespace GUI.Screens
{
    public partial class QuanLyNhanVien : UserControl
    {
        private NhanVienBLL qlnvBLL = new NhanVienBLL();
        private List<NhanVienDTO> dsnv;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            btnAdd_NV.Visible = true;
            
            if (Login._checkUrlMatch("themnhanvien:QLNV"))
            {
                btnAdd_NV.Visible = true;
            }
            else
            {
                btnAdd_NV.Visible = false;
            }
            
        }

        private void btnAdd_NV_Click(object sender, EventArgs e)
        {
            new AddNhanVien().Show();
        }

        private void btnReload_NV_Click(object sender, EventArgs e)
        {
            dataGridView_NV.DataSource = qlnvBLL.Display();
            txtFind_NV.Clear();
        }
        DataGridViewButtonColumn btn1, btn2;
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView_NV.DataSource = qlnvBLL.Display();
            btn1 = new DataGridViewButtonColumn();
            btn1.Name = "colUpdate";
            btn1.Text = "Sửa";
            btn1.HeaderText = "";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView_NV.Columns.Add(btn1);

            btn2 = new DataGridViewButtonColumn();
            btn2.Name = "colDelete";
            btn2.Text = "Xoá";
            btn2.HeaderText = "";
            btn2.UseColumnTextForButtonValue = true;
            dataGridView_NV.Columns.Add(btn2);

            if (Login._checkUrlMatch("suanhanvien:QLNV"))
            {
                btn1.Visible = true;
            }
            else
            {
                btn1.Visible = false;
            }
            if (Login._checkUrlMatch("xoanhanvien:QLNV"))
            {
                btn2.Visible = true;
            }
            else
            {
                btn2.Visible = false;
            }
        }

        private void btnSearch_NV_Click(object sender, EventArgs e)
        {
            string searchValue = txtFind_NV.Text;
            dataGridView_NV.DataSource = qlnvBLL.Show(searchValue);
        }

        private void dataGridView_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView_NV.Columns[e.ColumnIndex].Name;
            if (colname == "colUpdate")
            {
                dsnv = qlnvBLL.readDB();
                string sdt = dataGridView_NV.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                foreach(NhanVienDTO nv in dsnv)
                {
                    if (nv.phone.Equals(sdt))
                    {
                        new UpdateNhanVien(nv).Show();
                    }
                }
            }

            if (colname == "colDelete")
            {
                dsnv = qlnvBLL.readDB();
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string index = dataGridView_NV.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                    qlnvBLL.Delete(index);
                    dataGridView_NV.Rows.RemoveAt(e.RowIndex); //Xoá trực tiếp trên DataGridView nhưng ko xoá trong CSDL
                    MessageBox.Show("Đã xoá thành công!");
                }
            }
        }
    }
}
