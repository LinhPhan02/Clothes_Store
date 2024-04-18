
namespace GUI.Screens
{
    partial class GioHangBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GioHangBanHang));
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flow_spbh = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nhapKM = new System.Windows.Forms.TextBox();
            this.btn_confirmKM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flow_spbh.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.button2_Paint);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 32);
            this.label8.TabIndex = 9;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 43);
            this.label7.TabIndex = 8;
            this.label7.Text = "TOTAL:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // flow_spbh
            // 
            this.flow_spbh.AutoScroll = true;
            this.flow_spbh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flow_spbh.Controls.Add(this.panel2);
            this.flow_spbh.Location = new System.Drawing.Point(17, 90);
            this.flow_spbh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flow_spbh.Name = "flow_spbh";
            this.flow_spbh.Size = new System.Drawing.Size(1042, 578);
            this.flow_spbh.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 84);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(801, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 26);
            this.textBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(907, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mỹ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "300$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rolex";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đồng hồ Rolex";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // txt_nhapKM
            // 
            this.txt_nhapKM.Location = new System.Drawing.Point(453, 36);
            this.txt_nhapKM.Name = "txt_nhapKM";
            this.txt_nhapKM.Size = new System.Drawing.Size(210, 26);
            this.txt_nhapKM.TabIndex = 12;
            // 
            // btn_confirmKM
            // 
            this.btn_confirmKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btn_confirmKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmKM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirmKM.Location = new System.Drawing.Point(669, 28);
            this.btn_confirmKM.Name = "btn_confirmKM";
            this.btn_confirmKM.Size = new System.Drawing.Size(128, 42);
            this.btn_confirmKM.TabIndex = 13;
            this.btn_confirmKM.Text = "Xác nhận";
            this.btn_confirmKM.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thêm khuyến mãi:";
            // 
            // GioHangBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_confirmKM);
            this.Controls.Add(this.txt_nhapKM);
            this.Controls.Add(this.flow_spbh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GioHangBanHang";
            this.Size = new System.Drawing.Size(1080, 705);
            this.Load += new System.EventHandler(this.GioHangBanHang_Load);
            this.Click += new System.EventHandler(this.GioHangBanHang_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GioHangBanHang_Paint);
            this.flow_spbh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flow_spbh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhapKM;
        private System.Windows.Forms.Button btn_confirmKM;
        private System.Windows.Forms.Label label6;
    }
}
