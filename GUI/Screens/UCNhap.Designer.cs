
namespace GUI.Screens
{
    partial class UCNhap
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
            this.dataGridView_Nhap = new System.Windows.Forms.DataGridView();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Nhap
            // 
            this.dataGridView_Nhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Nhap.Location = new System.Drawing.Point(0, 80);
            this.dataGridView_Nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Nhap.Name = "dataGridView_Nhap";
            this.dataGridView_Nhap.RowHeadersWidth = 51;
            this.dataGridView_Nhap.Size = new System.Drawing.Size(1015, 544);
            this.dataGridView_Nhap.TabIndex = 2;
            this.dataGridView_Nhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Nhap_CellClick);
            this.dataGridView_Nhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Nhap_CellContentClick);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(49, 48);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(265, 22);
            this.dtp_start.TabIndex = 3;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(384, 48);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(265, 22);
            this.dtp_end.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(791, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 34);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(104, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày Bắt Đầu";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(428, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Kết Thúc";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(911, 38);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 34);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // UCNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.dataGridView_Nhap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNhap";
            this.Size = new System.Drawing.Size(1015, 624);
            this.Load += new System.EventHandler(this.UCNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Nhap;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
    }
}
