﻿namespace GUI.Popups
{
    partial class BanHangHasTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_namekh = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm khách hàng";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(156, 70);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 22);
            this.txt_search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // lbl_namekh
            // 
            this.lbl_namekh.AutoSize = true;
            this.lbl_namekh.Location = new System.Drawing.Point(153, 134);
            this.lbl_namekh.Name = "lbl_namekh";
            this.lbl_namekh.Size = new System.Drawing.Size(56, 16);
            this.lbl_namekh.TabIndex = 5;
            this.lbl_namekh.Text = "Chưa có";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(153, 167);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(14, 16);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng thanh toán";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BanHangHasTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_namekh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Name = "BanHangHasTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHangHasTK";
            this.Load += new System.EventHandler(this.BanHangHasTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_namekh;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}