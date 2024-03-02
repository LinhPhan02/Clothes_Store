namespace GUI.Screens
{
    partial class SPConBanHang
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.flowSPC = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số lượng:";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(560, 17);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(36, 19);
            this.lbl_qty.TabIndex = 17;
            this.lbl_qty.Text = "300";
            this.lbl_qty.Click += new System.EventHandler(this.label4_Click);
            // 
            // flowSPC
            // 
            this.flowSPC.AutoScroll = true;
            this.flowSPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowSPC.Location = new System.Drawing.Point(11, 57);
            this.flowSPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowSPC.Name = "flowSPC";
            this.flowSPC.Size = new System.Drawing.Size(598, 294);
            this.flowSPC.TabIndex = 18;
            this.flowSPC.Paint += new System.Windows.Forms.PaintEventHandler(this.flowSPC_Paint);
            // 
            // SPConBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 360);
            this.Controls.Add(this.flowSPC);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SPConBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPConBanHang";
            this.Load += new System.EventHandler(this.SPConBanHang_Load);
            this.Click += new System.EventHandler(this.SPConBanHang_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.FlowLayoutPanel flowSPC;
    }
}