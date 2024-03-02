
namespace GUI.Screens
{
    partial class NhapHangQLSP
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NhNCC = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(809, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NhNCC
            // 
            this.NhNCC.AutoScroll = true;
            this.NhNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NhNCC.Location = new System.Drawing.Point(17, 75);
            this.NhNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NhNCC.Name = "NhNCC";
            this.NhNCC.Size = new System.Drawing.Size(926, 463);
            this.NhNCC.TabIndex = 13;
            this.NhNCC.Paint += new System.Windows.Forms.PaintEventHandler(this.NhNCC_Paint);
            // 
            // NhapHangQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NhNCC);
            this.Controls.Add(this.comboBox1);
            this.Name = "NhapHangQLSP";
            this.Size = new System.Drawing.Size(960, 564);
            this.Load += new System.EventHandler(this.NhapHangQLSP_Load);
            this.Click += new System.EventHandler(this.NhapHangQLSP_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel NhNCC;
    }
}
