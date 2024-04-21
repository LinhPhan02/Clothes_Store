
namespace GUI.Screens
{
    partial class BanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gioHangBanHang2 = new GUI.Screens.GioHangBanHang();
            this.sanPhamBanHang1 = new GUI.Screens.SanPhamBanHang();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 633);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(434, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Giỏ hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 633);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 564);
            this.panel1.TabIndex = 4;
            // 
            // gioHangBanHang2
            // 
            this.gioHangBanHang2.Location = new System.Drawing.Point(29, 55);
            this.gioHangBanHang2.Name = "gioHangBanHang2";
            this.gioHangBanHang2.Size = new System.Drawing.Size(960, 564);
            this.gioHangBanHang2.TabIndex = 0;
            // 
            // sanPhamBanHang1
            // 
            this.sanPhamBanHang1.Location = new System.Drawing.Point(40, 52);
            this.sanPhamBanHang1.Name = "sanPhamBanHang1";
            this.sanPhamBanHang1.Size = new System.Drawing.Size(960, 564);
            this.sanPhamBanHang1.TabIndex = 5;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sanPhamBanHang1);
            this.Controls.Add(this.gioHangBanHang2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "BanHang";
            this.Size = new System.Drawing.Size(1015, 715);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private SanPhamBanHang sanPhamBanHangcs1;
        private GioHangBanHang gioHangBanHang1;
        private GioHangBanHang gioHangBanHang2;
        private SanPhamBanHang sanPhamBanHang1;
    }
}
