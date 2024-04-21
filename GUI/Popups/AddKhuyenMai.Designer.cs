namespace GUI.Popups
{
    partial class AddKhuyenMai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddKM = new System.Windows.Forms.Button();
            this.KetThucKM = new System.Windows.Forms.DateTimePicker();
            this.BatDauKM = new System.Windows.Forms.DateTimePicker();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_AddKM);
            this.panel2.Controls.Add(this.KetThucKM);
            this.panel2.Controls.Add(this.BatDauKM);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.txtTenKM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 200);
            this.panel2.TabIndex = 5;
            // 
            // btn_AddKM
            // 
            this.btn_AddKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AddKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddKM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddKM.Location = new System.Drawing.Point(642, 139);
            this.btn_AddKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddKM.Name = "btn_AddKM";
            this.btn_AddKM.Size = new System.Drawing.Size(111, 45);
            this.btn_AddKM.TabIndex = 12;
            this.btn_AddKM.Text = "Thêm ";
            this.btn_AddKM.UseVisualStyleBackColor = false;
            this.btn_AddKM.Click += new System.EventHandler(this.btn_AddKM_Click);
            // 
            // KetThucKM
            // 
            this.KetThucKM.Location = new System.Drawing.Point(508, 85);
            this.KetThucKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KetThucKM.Name = "KetThucKM";
            this.KetThucKM.Size = new System.Drawing.Size(245, 22);
            this.KetThucKM.TabIndex = 11;
            this.KetThucKM.Value = new System.DateTime(2024, 4, 20, 14, 54, 42, 0);
            // 
            // BatDauKM
            // 
            this.BatDauKM.Location = new System.Drawing.Point(508, 30);
            this.BatDauKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatDauKM.Name = "BatDauKM";
            this.BatDauKM.Size = new System.Drawing.Size(245, 22);
            this.BatDauKM.TabIndex = 10;
            this.BatDauKM.Value = new System.DateTime(2024, 4, 20, 14, 54, 42, 0);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(167, 86);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(172, 22);
            this.txtGiamGia.TabIndex = 9;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(167, 29);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(172, 22);
            this.txtTenKM.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giảm giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên khuyến mãi";
            // 
            // AddKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(796, 221);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khuyến mãi";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.DateTimePicker BatDauKM;
        private System.Windows.Forms.DateTimePicker KetThucKM;
        private System.Windows.Forms.Button btn_AddKM;
    }
}