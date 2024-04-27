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

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideBordersButton();
            trangChu1.BringToFront();
            ActiveSideBar(btn_home);
            lbl_user.Text = Login.user.Name;
            Privilege();
        }
        public void Privilege()
        {
            this.btn_banhang.Visible = false;
            this.btn_sanpham.Visible = false;
            this.btn_khuyenmai.Visible = false;
            this.btn_danhmuc.Visible = false;
            this.btn_nhacungcap.Visible = false;
            this.btn_nhanvien.Visible = false;
            this.btn_luong.Visible = false;
            this.btn_khachhang.Visible = false;
            this.btn_baohanh.Visible = false;
            this.btn_nhapxuat.Visible = false;
            this.btn_thongke.Visible = false;
            this.btn_phanquyen.Visible = false;
            List<string> listLeftMenu = LoginBLL._GetDataLeftMenu(Login.id_Privilege_group);
            for (int i = 0; i < listLeftMenu.Count; i++)
            {
                if (listLeftMenu[i] == "1")
                {
                    this.btn_banhang.Visible=true;
                }
                else if (listLeftMenu[i] == "2")
                {
                    this.btn_sanpham.Visible = true;
                }
                else if (listLeftMenu[i] == "3")
                {
                    this.btn_danhmuc.Visible = true;
                }
                else if (listLeftMenu[i] == "4")
                {
                    this.btn_nhacungcap.Visible = true;
                }
                else if (listLeftMenu[i] == "5")
                {
                    this.btn_nhanvien.Visible = true;
                }
                else if (listLeftMenu[i] == "6")
                {
                    this.btn_khachhang.Visible = true;
                }
                else if (listLeftMenu[i] == "7")
                {
                    this.btn_luong.Visible = true;
                }
                else if (listLeftMenu[i] == "8")
                {
                    this.btn_nhapxuat.Visible = true;
                }
                else if (listLeftMenu[i] == "9")
                {
                    this.btn_thongke.Visible = true;
                }
                else if (listLeftMenu[i] == "10")
                {
                    this.btn_khuyenmai.Visible = true;
                }
            }
            if (Login.id_Privilege_group == "0")
            {
                this.btn_phanquyen.Visible = true;
            }
        }
        public void HideBorderButton(Button btn)
        {
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        public void HideBordersButton()
        {
            HideBorderButton(btn_banhang);
            HideBorderButton(btn_home);
            HideBorderButton(btn_sanpham);
            HideBorderButton(btn_khuyenmai);
            HideBorderButton(btn_danhmuc);
            HideBorderButton(btn_nhacungcap);
            HideBorderButton(btn_nhanvien);
            HideBorderButton(btn_luong);
            HideBorderButton(btn_khachhang);
            HideBorderButton(btn_logout);
            HideBorderButton(btn_baohanh);
            HideBorderButton(btn_thongke);
            HideBorderButton(btn_nhapxuat);
            HideBorderButton(btn_phanquyen);
        }

        public void ActiveSideBar(Button btn)
        {
            btn_banhang.BackColor = Color.Transparent;
            btn_home.BackColor = Color.Transparent;
            btn_sanpham.BackColor = Color.Transparent;
            btn_khuyenmai.BackColor = Color.Transparent;
            btn_danhmuc.BackColor = Color.Transparent;
            btn_nhacungcap.BackColor = Color.Transparent;
            btn_nhanvien.BackColor = Color.Transparent;
            btn_luong.BackColor = Color.Transparent;
            btn_baohanh.BackColor = Color.Transparent;
            btn_thongke.BackColor = Color.Transparent;
            btn_nhapxuat.BackColor = Color.Transparent;
            btn_khachhang.BackColor = Color.Transparent;
            btn_phanquyen.BackColor = Color.Transparent;
            btn.BackColor = Color.FromArgb(58, 0, 142);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void btn_home_Click(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
            ActiveSideBar(btn_home);
        }
        
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            banHang1.BringToFront();
            ActiveSideBar(btn_banhang);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            quanLySanPham1.BringToFront();
            ActiveSideBar(btn_sanpham);
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            khuyenMai1.BringToFront();
            ActiveSideBar(btn_khuyenmai);
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            quanLyDanhMuc1.BringToFront();
            quanLyDanhMuc1.loadData();
            ActiveSideBar(btn_danhmuc);
        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            quanLyNhaCungCap1.BringToFront();
            ActiveSideBar(btn_nhacungcap);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            quanLyNhanVien1.BringToFront();
            ActiveSideBar(btn_nhanvien);
        }
        private void btn_salary_Click(object sender, EventArgs e)
        {
            quanLyLuong1.BringToFront();
            ActiveSideBar(btn_luong);
        }
        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            quanLyKhachHang1.BringToFront();
            ActiveSideBar(btn_khachhang);
        }

        private void btn_nhapxuat_Click(object sender, EventArgs e)
        {
            nhapXuat1.BringToFront();
            nhapXuat1.btn_pxuat_Click(sender,e);
            ActiveSideBar(btn_nhapxuat);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            thongKe1.BringToFront();
            ActiveSideBar(btn_thongke);
        }

        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            phanQuyen1.BringToFront();
            ActiveSideBar(btn_phanquyen);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void khuyenMai1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_text_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quanLyLuong1_Load(object sender, EventArgs e)
        {

        }

        private void phanQuyen1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyNhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyKhachHang1_Load(object sender, EventArgs e)
        {

        }

        private void banHang1_Load(object sender, EventArgs e)
        {

        }

        private void nhapXuat1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyBaoHanh1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyDanhMuc1_Load(object sender, EventArgs e)
        {

        }

        private void quanLyNhaCungCap1_Load(object sender, EventArgs e)
        {

        }

        private void quanLySanPham1_Load(object sender, EventArgs e)
        {

        }

        private void thongKe1_Load(object sender, EventArgs e)
        {

        }

        private void trangChu1_Load(object sender, EventArgs e)
        {

        }
    }
}
