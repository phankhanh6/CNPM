namespace QuanLyPX
{
    partial class DSXe
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
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_timKiem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.tb_ghiChu = new System.Windows.Forms.TextBox();
            this.tb_tenXe = new System.Windows.Forms.TextBox();
            this.tb_maXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox2
            // 
            this.groupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupbox2.Controls.Add(this.dgvXe);
            this.groupbox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox2.Location = new System.Drawing.Point(0, 55);
            this.groupbox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupbox2.Size = new System.Drawing.Size(356, 446);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Danh sách xe ";
            this.groupbox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(0, 24);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(345, 418);
            this.dgvXe.TabIndex = 0;
            this.dgvXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Xe ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(584, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bt_thoat);
            this.groupBox4.Controls.Add(this.bt_sua);
            this.groupBox4.Controls.Add(this.bt_them);
            this.groupBox4.Controls.Add(this.bt_xoa);
            this.groupBox4.Controls.Add(this.bt_timKiem);
            this.groupBox4.Location = new System.Drawing.Point(0, 506);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(584, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(453, 32);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(56, 26);
            this.bt_thoat.TabIndex = 18;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(353, 32);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(56, 26);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(124, 32);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(56, 26);
            this.bt_them.TabIndex = 16;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(241, 32);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(56, 26);
            this.bt_xoa.TabIndex = 15;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_timKiem
            // 
            this.bt_timKiem.Location = new System.Drawing.Point(21, 32);
            this.bt_timKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_timKiem.Name = "bt_timKiem";
            this.bt_timKiem.Size = new System.Drawing.Size(56, 26);
            this.bt_timKiem.TabIndex = 14;
            this.bt_timKiem.Text = "Tìm kiếm";
            this.bt_timKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.bt_huy);
            this.groupBox5.Controls.Add(this.bt_luu);
            this.groupBox5.Controls.Add(this.tb_ghiChu);
            this.groupBox5.Controls.Add(this.tb_tenXe);
            this.groupBox5.Controls.Add(this.tb_maXe);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(350, 57);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(234, 444);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi Tiết";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(169, 147);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(56, 29);
            this.bt_huy.TabIndex = 15;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(59, 147);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(56, 29);
            this.bt_luu.TabIndex = 14;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // tb_ghiChu
            // 
            this.tb_ghiChu.Location = new System.Drawing.Point(56, 98);
            this.tb_ghiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ghiChu.Name = "tb_ghiChu";
            this.tb_ghiChu.Size = new System.Drawing.Size(170, 20);
            this.tb_ghiChu.TabIndex = 13;
            // 
            // tb_tenXe
            // 
            this.tb_tenXe.Location = new System.Drawing.Point(56, 63);
            this.tb_tenXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tenXe.Name = "tb_tenXe";
            this.tb_tenXe.Size = new System.Drawing.Size(170, 20);
            this.tb_tenXe.TabIndex = 12;
            // 
            // tb_maXe
            // 
            this.tb_maXe.Location = new System.Drawing.Point(56, 26);
            this.tb_maXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_maXe.Name = "tb_maXe";
            this.tb_maXe.Size = new System.Drawing.Size(170, 20);
            this.tb_maXe.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã xe";
            // 
            // DSXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 588);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DSXe";
            this.Text = "DSXe";
            this.Load += new System.EventHandler(this.DSXe_Load);
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_timKiem;
        private System.Windows.Forms.TextBox tb_ghiChu;
        private System.Windows.Forms.TextBox tb_tenXe;
        private System.Windows.Forms.TextBox tb_maXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.DataGridView dgvXe;
    }
}