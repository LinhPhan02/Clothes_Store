
namespace GUI.Screens
{
    partial class SanPhamQLSP
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
            this.panelForm = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(37, 75);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(873, 475);
            this.panelForm.TabIndex = 12;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 14;
            // 
            // SanPhamQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SanPhamQLSP";
            this.Size = new System.Drawing.Size(960, 564);
            this.Load += new System.EventHandler(this.SanPhamQLSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelForm;
        private System.Windows.Forms.TextBox textBox1;
    }
}
