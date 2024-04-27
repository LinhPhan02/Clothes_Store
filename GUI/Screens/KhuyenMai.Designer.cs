namespace GUI.Screens
{
    partial class KhuyenMai
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
            this.txtFind_KM = new System.Windows.Forms.TextBox();
            this.dataGridView_KM = new System.Windows.Forms.DataGridView();
            this.btnReload_KM = new System.Windows.Forms.PictureBox();
            this.btnSearch_KM = new System.Windows.Forms.PictureBox();
            this.btnAdd_KM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_KM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_KM)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind_KM
            // 
            this.txtFind_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind_KM.Location = new System.Drawing.Point(24, 62);
            this.txtFind_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind_KM.Name = "txtFind_KM";
            this.txtFind_KM.Size = new System.Drawing.Size(325, 24);
            this.txtFind_KM.TabIndex = 13;
            // 
            // dataGridView_KM
            // 
            this.dataGridView_KM.AllowUserToAddRows = false;
            this.dataGridView_KM.AllowUserToResizeColumns = false;
            this.dataGridView_KM.AllowUserToResizeRows = false;
            this.dataGridView_KM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KM.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_KM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_KM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KM.GridColor = System.Drawing.Color.White;
            this.dataGridView_KM.Location = new System.Drawing.Point(24, 132);
            this.dataGridView_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_KM.MultiSelect = false;
            this.dataGridView_KM.Name = "dataGridView_KM";
            this.dataGridView_KM.RowHeadersVisible = false;
            this.dataGridView_KM.RowHeadersWidth = 51;
            this.dataGridView_KM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_KM.ShowEditingIcon = false;
            this.dataGridView_KM.Size = new System.Drawing.Size(967, 550);
            this.dataGridView_KM.TabIndex = 17;
            this.dataGridView_KM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KM_CellClick);
            // 
            // btnReload_KM
            // 
            this.btnReload_KM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnReload_KM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload_KM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReload_KM.Image = global::GUI.Properties.Resources.icons8_refresh_30;
            this.btnReload_KM.Location = new System.Drawing.Point(404, 62);
            this.btnReload_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload_KM.Name = "btnReload_KM";
            this.btnReload_KM.Size = new System.Drawing.Size(38, 25);
            this.btnReload_KM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload_KM.TabIndex = 16;
            this.btnReload_KM.TabStop = false;
            this.btnReload_KM.Click += new System.EventHandler(this.btnReload_KM_Click);
            // 
            // btnSearch_KM
            // 
            this.btnSearch_KM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnSearch_KM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch_KM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch_KM.Image = global::GUI.Properties.Resources.icons8_search_30;
            this.btnSearch_KM.Location = new System.Drawing.Point(349, 62);
            this.btnSearch_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch_KM.Name = "btnSearch_KM";
            this.btnSearch_KM.Size = new System.Drawing.Size(38, 25);
            this.btnSearch_KM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch_KM.TabIndex = 15;
            this.btnSearch_KM.TabStop = false;
            this.btnSearch_KM.Click += new System.EventHandler(this.btnSearch_KM_Click);
            // 
            // btnAdd_KM
            // 
            this.btnAdd_KM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdd_KM.FlatAppearance.BorderSize = 0;
            this.btnAdd_KM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_KM.ForeColor = System.Drawing.Color.White;
            this.btnAdd_KM.Image = global::GUI.Properties.Resources.icons8_add_30;
            this.btnAdd_KM.Location = new System.Drawing.Point(876, 53);
            this.btnAdd_KM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd_KM.Name = "btnAdd_KM";
            this.btnAdd_KM.Size = new System.Drawing.Size(115, 42);
            this.btnAdd_KM.TabIndex = 14;
            this.btnAdd_KM.UseVisualStyleBackColor = false;
            this.btnAdd_KM.Click += new System.EventHandler(this.btnAdd_KM_Click);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_KM);
            this.Controls.Add(this.btnReload_KM);
            this.Controls.Add(this.txtFind_KM);
            this.Controls.Add(this.btnSearch_KM);
            this.Controls.Add(this.btnAdd_KM);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhuyenMai";
            this.Size = new System.Drawing.Size(1015, 715);
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload_KM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch_KM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnReload_KM;
        private System.Windows.Forms.TextBox txtFind_KM;
        private System.Windows.Forms.PictureBox btnSearch_KM;
        private System.Windows.Forms.Button btnAdd_KM;
        private System.Windows.Forms.DataGridView dataGridView_KM;
    }
}
