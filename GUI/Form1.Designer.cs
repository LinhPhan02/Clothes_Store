﻿
using BLL;
using System.Collections.Generic;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hide = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.logo_text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_khuyenmai = new System.Windows.Forms.Button();
            this.btn_danhmuc = new System.Windows.Forms.Button();
            this.btn_nhacungcap = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_luong = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_nhapxuat = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_phanquyen = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_baohanh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.khuyenMai1 = new GUI.Screens.KhuyenMai();
            this.quanLyLuong1 = new GUI.Screens.QuanLyLuong();
            this.phanQuyen1 = new GUI.Screens.PhanQuyen();
            this.quanLyNhanVien1 = new GUI.Screens.QuanLyNhanVien();
            this.quanLyKhachHang1 = new GUI.Screens.QuanLyKhachHang();
            this.banHang1 = new GUI.Screens.BanHang();
            this.nhapXuat1 = new GUI.Screens.NhapXuat();
            this.quanLyDanhMuc1 = new GUI.Screens.QuanLyDanhMuc();
            this.quanLyNhaCungCap1 = new GUI.Screens.QuanLyNhaCungCap();
            this.quanLySanPham1 = new GUI.Screens.QuanLySanPham();
            this.thongKe1 = new GUI.Screens.ThongKe();
            this.trangChu1 = new GUI.Screens.TrangChu();
            this.btn_khuyenmai1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logo_text);
            this.panel2.Location = new System.Drawing.Point(304, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 94);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(673, 36);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(61, 20);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Admin";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.hide);
            this.panel3.Controls.Add(this.close);
            this.panel3.Location = new System.Drawing.Point(800, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 37);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(186)))), ((int)(((byte)(211)))));
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(97, 0);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(57, 29);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide.TabIndex = 3;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(134)))));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(151, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // logo_text
            // 
            this.logo_text.AutoSize = true;
            this.logo_text.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_text.Location = new System.Drawing.Point(36, 27);
            this.logo_text.Name = "logo_text";
            this.logo_text.Size = new System.Drawing.Size(157, 35);
            this.logo_text.TabIndex = 2;
            this.logo_text.Text = "Dashboard";
            this.logo_text.Click += new System.EventHandler(this.logo_text_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_banhang);
            this.panel1.Controls.Add(this.btn_sanpham);
            this.panel1.Controls.Add(this.btn_khuyenmai);
            this.panel1.Controls.Add(this.btn_danhmuc);
            this.panel1.Controls.Add(this.btn_nhacungcap);
            this.panel1.Controls.Add(this.btn_nhanvien);
            this.panel1.Controls.Add(this.btn_luong);
            this.panel1.Controls.Add(this.btn_khachhang);
            this.panel1.Controls.Add(this.btn_nhapxuat);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_phanquyen);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 855);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 77);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(303, 55);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "          Trang chủ";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.ForeColor = System.Drawing.Color.White;
            this.btn_banhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_banhang.Image")));
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(3, 138);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(303, 55);
            this.btn_banhang.TabIndex = 1;
            this.btn_banhang.Text = "          Bán hàng";
            this.btn_banhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.UseVisualStyleBackColor = false;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sanpham.ForeColor = System.Drawing.Color.White;
            this.btn_sanpham.Image = ((System.Drawing.Image)(resources.GetObject("btn_sanpham.Image")));
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(3, 199);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(303, 55);
            this.btn_sanpham.TabIndex = 14;
            this.btn_sanpham.Text = "          Quản lý sản phẩm";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.UseVisualStyleBackColor = false;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_khuyenmai
            // 
            this.btn_khuyenmai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_khuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khuyenmai.ForeColor = System.Drawing.Color.White;
            this.btn_khuyenmai.Image = ((System.Drawing.Image)(resources.GetObject("btn_khuyenmai.Image")));
            this.btn_khuyenmai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai.Location = new System.Drawing.Point(3, 260);
            this.btn_khuyenmai.Name = "btn_khuyenmai";
            this.btn_khuyenmai.Size = new System.Drawing.Size(303, 55);
            this.btn_khuyenmai.TabIndex = 25;
            this.btn_khuyenmai.Text = "          Quản lý khuyến mãi";
            this.btn_khuyenmai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai.UseVisualStyleBackColor = false;
            this.btn_khuyenmai.Click += new System.EventHandler(this.btn_khuyenmai_Click);
            // 
            // btn_danhmuc
            // 
            this.btn_danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhmuc.ForeColor = System.Drawing.Color.White;
            this.btn_danhmuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhmuc.Image")));
            this.btn_danhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhmuc.Location = new System.Drawing.Point(3, 321);
            this.btn_danhmuc.Name = "btn_danhmuc";
            this.btn_danhmuc.Size = new System.Drawing.Size(303, 55);
            this.btn_danhmuc.TabIndex = 15;
            this.btn_danhmuc.Text = "          Quản lý danh mục";
            this.btn_danhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhmuc.UseVisualStyleBackColor = false;
            this.btn_danhmuc.Click += new System.EventHandler(this.btn_danhmuc_Click);
            // 
            // btn_nhacungcap
            // 
            this.btn_nhacungcap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhacungcap.ForeColor = System.Drawing.Color.White;
            this.btn_nhacungcap.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhacungcap.Image")));
            this.btn_nhacungcap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhacungcap.Location = new System.Drawing.Point(3, 382);
            this.btn_nhacungcap.Name = "btn_nhacungcap";
            this.btn_nhacungcap.Size = new System.Drawing.Size(303, 55);
            this.btn_nhacungcap.TabIndex = 16;
            this.btn_nhacungcap.Text = "          Quản lý nhà cung cấp";
            this.btn_nhacungcap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhacungcap.UseVisualStyleBackColor = false;
            this.btn_nhacungcap.Click += new System.EventHandler(this.btn_nhacungcap_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien.Image")));
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(3, 443);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(303, 55);
            this.btn_nhanvien.TabIndex = 17;
            this.btn_nhanvien.Text = "          Quản lý nhân viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_luong
            // 
            this.btn_luong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luong.ForeColor = System.Drawing.Color.White;
            this.btn_luong.Image = ((System.Drawing.Image)(resources.GetObject("btn_luong.Image")));
            this.btn_luong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luong.Location = new System.Drawing.Point(3, 504);
            this.btn_luong.Name = "btn_luong";
            this.btn_luong.Size = new System.Drawing.Size(303, 55);
            this.btn_luong.TabIndex = 24;
            this.btn_luong.Text = "          Quản lý lương";
            this.btn_luong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luong.UseVisualStyleBackColor = false;
            this.btn_luong.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.ForeColor = System.Drawing.Color.White;
            this.btn_khachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.Image")));
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(3, 565);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(303, 55);
            this.btn_khachhang.TabIndex = 18;
            this.btn_khachhang.Text = "          Quản lý khách hàng";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.UseVisualStyleBackColor = false;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_nhapxuat
            // 
            this.btn_nhapxuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhapxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapxuat.ForeColor = System.Drawing.Color.White;
            this.btn_nhapxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhapxuat.Image")));
            this.btn_nhapxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapxuat.Location = new System.Drawing.Point(3, 626);
            this.btn_nhapxuat.Name = "btn_nhapxuat";
            this.btn_nhapxuat.Size = new System.Drawing.Size(303, 55);
            this.btn_nhapxuat.TabIndex = 20;
            this.btn_nhapxuat.Text = "          Quản lý nhập xuất";
            this.btn_nhapxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapxuat.UseVisualStyleBackColor = false;
            this.btn_nhapxuat.Click += new System.EventHandler(this.btn_nhapxuat_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongke.Image")));
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(3, 687);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(303, 55);
            this.btn_thongke.TabIndex = 21;
            this.btn_thongke.Text = "          Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_phanquyen
            // 
            this.btn_phanquyen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_phanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phanquyen.ForeColor = System.Drawing.Color.White;
            this.btn_phanquyen.Image = ((System.Drawing.Image)(resources.GetObject("btn_phanquyen.Image")));
            this.btn_phanquyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phanquyen.Location = new System.Drawing.Point(3, 748);
            this.btn_phanquyen.Name = "btn_phanquyen";
            this.btn_phanquyen.Size = new System.Drawing.Size(303, 55);
            this.btn_phanquyen.TabIndex = 23;
            this.btn_phanquyen.Text = "          Phân quyền";
            this.btn_phanquyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phanquyen.UseVisualStyleBackColor = false;
            this.btn_phanquyen.Click += new System.EventHandler(this.btn_phanquyen_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(3, 809);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(303, 55);
            this.btn_logout.TabIndex = 22;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.khuyenMai1);
            this.panel4.Controls.Add(this.quanLyLuong1);
            this.panel4.Controls.Add(this.phanQuyen1);
            this.panel4.Controls.Add(this.quanLyNhanVien1);
            this.panel4.Controls.Add(this.quanLyKhachHang1);
            this.panel4.Controls.Add(this.banHang1);
            this.panel4.Controls.Add(this.nhapXuat1);
            this.panel4.Controls.Add(this.quanLyDanhMuc1);
            this.panel4.Controls.Add(this.quanLyNhaCungCap1);
            this.panel4.Controls.Add(this.quanLySanPham1);
            this.panel4.Controls.Add(this.thongKe1);
            this.panel4.Controls.Add(this.trangChu1);
            this.panel4.Location = new System.Drawing.Point(304, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 715);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // khuyenMai1
            // 
            this.khuyenMai1.Location = new System.Drawing.Point(0, 0);
            this.khuyenMai1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khuyenMai1.Name = "khuyenMai1";
            this.khuyenMai1.Size = new System.Drawing.Size(1015, 715);
            this.khuyenMai1.TabIndex = 12;
            this.khuyenMai1.Load += new System.EventHandler(this.khuyenMai1_Load);
            // 
            // quanLyLuong1
            // 
            this.quanLyLuong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyLuong1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quanLyLuong1.Name = "quanLyLuong1";
            this.quanLyLuong1.Size = new System.Drawing.Size(1015, 715);
            this.quanLyLuong1.TabIndex = 11;
            this.quanLyLuong1.Load += new System.EventHandler(this.quanLyLuong1_Load);
            // 
            // phanQuyen1
            // 
            this.phanQuyen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phanQuyen1.Location = new System.Drawing.Point(0, 0);
            this.phanQuyen1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phanQuyen1.Name = "phanQuyen1";
            this.phanQuyen1.Size = new System.Drawing.Size(1015, 715);
            this.phanQuyen1.TabIndex = 10;
            this.phanQuyen1.Load += new System.EventHandler(this.phanQuyen1_Load);
            // 
            // quanLyNhanVien1
            // 
            this.quanLyNhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.quanLyNhanVien1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quanLyNhanVien1.Name = "quanLyNhanVien1";
            this.quanLyNhanVien1.Size = new System.Drawing.Size(1015, 715);
            this.quanLyNhanVien1.TabIndex = 9;
            this.quanLyNhanVien1.Load += new System.EventHandler(this.quanLyNhanVien1_Load);
            // 
            // quanLyKhachHang1
            // 
            this.quanLyKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.quanLyKhachHang1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quanLyKhachHang1.Name = "quanLyKhachHang1";
            this.quanLyKhachHang1.Size = new System.Drawing.Size(1015, 715);
            this.quanLyKhachHang1.TabIndex = 8;
            this.quanLyKhachHang1.Load += new System.EventHandler(this.quanLyKhachHang1_Load);
            // 
            // banHang1
            // 
            this.banHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banHang1.Location = new System.Drawing.Point(0, 0);
            this.banHang1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.banHang1.Name = "banHang1";
            this.banHang1.Size = new System.Drawing.Size(1015, 715);
            this.banHang1.TabIndex = 7;
            this.banHang1.Load += new System.EventHandler(this.banHang1_Load);
            // 
            // nhapXuat1
            // 
            this.nhapXuat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhapXuat1.Location = new System.Drawing.Point(0, 0);
            this.nhapXuat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapXuat1.Name = "nhapXuat1";
            this.nhapXuat1.Size = new System.Drawing.Size(1015, 715);
            this.nhapXuat1.TabIndex = 6;
            this.nhapXuat1.Load += new System.EventHandler(this.nhapXuat1_Load);
            // 
            // quanLyDanhMuc1
            // 
            this.quanLyDanhMuc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyDanhMuc1.Location = new System.Drawing.Point(0, 0);
            this.quanLyDanhMuc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quanLyDanhMuc1.Name = "quanLyDanhMuc1";
            this.quanLyDanhMuc1.Size = new System.Drawing.Size(1015, 715);
            this.quanLyDanhMuc1.TabIndex = 4;
            this.quanLyDanhMuc1.Load += new System.EventHandler(this.quanLyDanhMuc1_Load);
            // 
            // quanLyNhaCungCap1
            // 
            this.quanLyNhaCungCap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNhaCungCap1.Location = new System.Drawing.Point(0, 0);
            this.quanLyNhaCungCap1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quanLyNhaCungCap1.Name = "quanLyNhaCungCap1";
            this.quanLyNhaCungCap1.Size = new System.Drawing.Size(1015, 715);
            this.quanLyNhaCungCap1.TabIndex = 3;
            this.quanLyNhaCungCap1.Load += new System.EventHandler(this.quanLyNhaCungCap1_Load);
            // 
            // quanLySanPham1
            // 
            this.quanLySanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLySanPham1.Location = new System.Drawing.Point(0, 0);
            this.quanLySanPham1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quanLySanPham1.Name = "quanLySanPham1";
            this.quanLySanPham1.Size = new System.Drawing.Size(1015, 715);
            this.quanLySanPham1.TabIndex = 2;
            this.quanLySanPham1.Load += new System.EventHandler(this.quanLySanPham1_Load);
            // 
            // thongKe1
            // 
            this.thongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongKe1.Location = new System.Drawing.Point(0, 0);
            this.thongKe1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(1015, 715);
            this.thongKe1.TabIndex = 1;
            this.thongKe1.Load += new System.EventHandler(this.thongKe1_Load);
            // 
            // trangChu1
            // 
            this.trangChu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChu1.Location = new System.Drawing.Point(0, 0);
            this.trangChu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trangChu1.Name = "trangChu1";
            this.trangChu1.Size = new System.Drawing.Size(1015, 715);
            this.trangChu1.TabIndex = 0;
            this.trangChu1.Load += new System.EventHandler(this.trangChu1_Load);
            // 
            // btn_khuyenmai1
            // 
            this.btn_khuyenmai1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_khuyenmai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khuyenmai1.ForeColor = System.Drawing.Color.White;
            this.btn_khuyenmai1.Image = global::GUI.Properties.Resources.icons8_edit_property_24px;
            this.btn_khuyenmai1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai1.Location = new System.Drawing.Point(3, 328);
            this.btn_khuyenmai1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_khuyenmai1.Name = "btn_khuyenmai1";
            this.btn_khuyenmai1.Size = new System.Drawing.Size(341, 69);
            this.btn_khuyenmai1.TabIndex = 15;
            this.btn_khuyenmai1.Text = "          Quản lý khuyến mãi";
            this.btn_khuyenmai1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khuyenmai1.UseVisualStyleBackColor = false;
            this.btn_khuyenmai1.Click += new System.EventHandler(this.btn_khuyenmai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1315, 853);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1315, 853);
            this.MinimumSize = new System.Drawing.Size(1315, 853);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox hide;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label logo_text;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_banhang;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel4;
        private Screens.TrangChu trangChu1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_sanpham;
        private System.Windows.Forms.Button btn_khuyenmai;
        private System.Windows.Forms.Button btn_danhmuc;
        private System.Windows.Forms.Button btn_nhacungcap;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_luong;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_baohanh;
        private System.Windows.Forms.Button btn_nhapxuat;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_phanquyen;
        private System.Windows.Forms.Button btn_logout;
        private Screens.PhanQuyen phanQuyen1;
        private Screens.QuanLyNhanVien quanLyNhanVien1;
        private Screens.QuanLyKhachHang quanLyKhachHang1;
        private Screens.BanHang banHang1;
        private Screens.NhapXuat nhapXuat1;
        private Screens.QuanLyDanhMuc quanLyDanhMuc1;
        private Screens.QuanLyNhaCungCap quanLyNhaCungCap1;
        private Screens.QuanLySanPham quanLySanPham1;
        private Screens.ThongKe thongKe1;
        private Screens.QuanLyLuong quanLyLuong1;
        private System.Windows.Forms.Button btn_khuyenmai1;
        private Screens.KhuyenMai khuyenMai1;
    }
}

