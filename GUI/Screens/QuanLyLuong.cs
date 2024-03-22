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
    public partial class QuanLyLuong : UserControl
    {
        private LuongBLL qllBLL = new LuongBLL();
        private List<LuongDTO> dsl;
        public QuanLyLuong()
        {
            InitializeComponent();
            btnAdd_HĐ.Visible = true;
        }

        private void dataGridView_HĐ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            string colname = dataGridView_HĐ.Columns[e.ColumnIndex].Name;
            if (colname == "colUpdate")
            {
                dsl = qllBLL.readDB();
                string sdt = dataGridView_HĐ.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                foreach (LuongDTO l in dsl)
                {
                    if (nv.phone.Equals(sdt))
                    {
                        new UpdateNhanVien(nv).Show();
                    }
                }
            }

            if (colname == "colDelete")
            {
                dshd = qllBLL.readDB();
                if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string index = dataGridView_HĐ.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                    qllBLL.Delete(index);
                    dataGridView_HĐ.Rows.RemoveAt(e.RowIndex); //Xoá trực tiếp trên DataGridView nhưng ko xoá trong CSDL
                    MessageBox.Show("Đã xoá thành công!");
                }
            }
            */
        }

        private void btnSearch_HĐ_Click(object sender, EventArgs e)
        {
            string searchValue = txtFind_HĐ.Text;
            dataGridView_HĐ.DataSource = qllBLL.Show(searchValue);
        }

        private void QuanLyLuong_Load(object sender, EventArgs e)
        {
            dataGridView_HĐ.DataSource = qllBLL.Display();
            /*
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
            */
        }

        private void btnReload_HĐ_Click(object sender, EventArgs e)
        {
            dataGridView_HĐ.DataSource = qllBLL.Display();
            txtFind_HĐ.Clear();
        }

        private void btnAdd_HĐ_Click(object sender, EventArgs e)
        {
            new AddHopDong().Show();
        }
    }
}
