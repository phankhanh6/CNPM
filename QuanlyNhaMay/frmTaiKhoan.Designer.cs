
namespace QuanlyNhaMay
{
    partial class frmTaiKhoan
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
            this.txt_tk = new DevExpress.XtraEditors.TextEdit();
            this.txt_mk = new DevExpress.XtraEditors.TextEdit();
            this.lb_taiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tk
            // 
            this.txt_tk.EditValue = "";
            this.txt_tk.Location = new System.Drawing.Point(642, 73);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(219, 22);
            this.txt_tk.TabIndex = 0;
            this.txt_tk.EditValueChanged += new System.EventHandler(this.txt_tk_EditValueChanged);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(642, 101);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(219, 22);
            this.txt_mk.TabIndex = 1;
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.Location = new System.Drawing.Point(561, 76);
            this.lb_taiKhoan.Name = "lb_taiKhoan";
            this.lb_taiKhoan.Size = new System.Drawing.Size(60, 17);
            this.lb_taiKhoan.TabIndex = 2;
            this.lb_taiKhoan.Text = "Tài Khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(564, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(642, 159);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(94, 29);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(642, 129);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Lưu mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(140, 24);
            this.checkEdit1.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(767, 159);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(94, 29);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanlyNhaMay.Properties.Resources.Khanhminh;
            this.ClientSize = new System.Drawing.Size(883, 465);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lb_taiKhoan);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.DoubleBuffered = true;
            this.IconOptions.Image = global::QuanlyNhaMay.Properties.Resources.sports_car;
            this.Name = "frmTaiKhoan";
            this.Text = "Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_tk;
        private DevExpress.XtraEditors.TextEdit txt_mk;
        private DevExpress.XtraEditors.LabelControl lb_taiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_dangnhap;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
    }
}