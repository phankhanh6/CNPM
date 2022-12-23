
namespace QuanlyNhaMay
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_gioithieu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Taikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Tho = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NuocSX = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Phukien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Phancong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thanhphan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DSXe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_hoadon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DSPhukien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LocXe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LocPhukien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LocThanhphan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_helpchucnang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Contact = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_Hethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Danhmuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_InAn = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon_Help = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barSubItem1,
            this.btn_gioithieu,
            this.btn_Taikhoan,
            this.btn_Xe,
            this.btn_Tho,
            this.btn_NuocSX,
            this.btn_Phukien,
            this.btn_Phancong,
            this.btn_Thanhphan,
            this.btn_DSXe,
            this.btn_hoadon,
            this.btn_DSPhukien,
            this.btn_LocXe,
            this.btn_LocPhukien,
            this.btn_LocThanhphan,
            this.btn_helpchucnang,
            this.barButtonItem2,
            this.btn_Contact});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbon_Hethong,
            this.ribbon_Danhmuc,
            this.ribbon_InAn,
            this.ribbon_Help});
            this.ribbonControl1.Size = new System.Drawing.Size(1091, 193);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_gioithieu
            // 
            this.btn_gioithieu.Caption = "Giới thiệu\r\n";
            this.btn_gioithieu.Id = 2;
            this.btn_gioithieu.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.giới_thiệu;
            this.btn_gioithieu.Name = "btn_gioithieu";
            this.btn_gioithieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_gioithieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_trangchu_ItemClick);
            // 
            // btn_Taikhoan
            // 
            this.btn_Taikhoan.Caption = "Tài khoản";
            this.btn_Taikhoan.Id = 3;
            this.btn_Taikhoan.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.id_card;
            this.btn_Taikhoan.Name = "btn_Taikhoan";
            this.btn_Taikhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Taikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Taikhoan_ItemClick);
            // 
            // btn_Xe
            // 
            this.btn_Xe.Caption = "Xe";
            this.btn_Xe.Id = 4;
            this.btn_Xe.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.sports_car;
            this.btn_Xe.Name = "btn_Xe";
            this.btn_Xe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Xe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xe_ItemClick);
            // 
            // btn_Tho
            // 
            this.btn_Tho.Caption = "Thợ";
            this.btn_Tho.Id = 5;
            this.btn_Tho.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.tho;
            this.btn_Tho.Name = "btn_Tho";
            this.btn_Tho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Tho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Tho_ItemClick);
            // 
            // btn_NuocSX
            // 
            this.btn_NuocSX.Caption = "Nước sản xuất";
            this.btn_NuocSX.Id = 6;
            this.btn_NuocSX.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.nuoc;
            this.btn_NuocSX.Name = "btn_NuocSX";
            this.btn_NuocSX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_NuocSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NuocSX_ItemClick);
            // 
            // btn_Phukien
            // 
            this.btn_Phukien.Caption = "Phụ kiện";
            this.btn_Phukien.Id = 7;
            this.btn_Phukien.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.phụ_kiện;
            this.btn_Phukien.Name = "btn_Phukien";
            this.btn_Phukien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Phukien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Phukien_ItemClick);
            // 
            // btn_Phancong
            // 
            this.btn_Phancong.Caption = "Phân công";
            this.btn_Phancong.Id = 8;
            this.btn_Phancong.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.phân_công;
            this.btn_Phancong.Name = "btn_Phancong";
            this.btn_Phancong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Phancong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Phancong_ItemClick);
            // 
            // btn_Thanhphan
            // 
            this.btn_Thanhphan.Caption = "Thành phần";
            this.btn_Thanhphan.Id = 9;
            this.btn_Thanhphan.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.thanh_phan;
            this.btn_Thanhphan.Name = "btn_Thanhphan";
            this.btn_Thanhphan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Thanhphan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thanhphan_ItemClick);
            // 
            // btn_DSXe
            // 
            this.btn_DSXe.Caption = "Danh sách xe";
            this.btn_DSXe.Id = 10;
            this.btn_DSXe.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.sports_car;
            this.btn_DSXe.Name = "btn_DSXe";
            this.btn_DSXe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DSXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DSXe_ItemClick);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Caption = "In hóa đơn";
            this.btn_hoadon.Id = 11;
            this.btn_hoadon.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.phân_công;
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_hoadon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_hoadon_ItemClick);
            // 
            // btn_DSPhukien
            // 
            this.btn_DSPhukien.Caption = "Danh sách phụ kiện";
            this.btn_DSPhukien.Id = 12;
            this.btn_DSPhukien.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.phụ_kiện;
            this.btn_DSPhukien.Name = "btn_DSPhukien";
            this.btn_DSPhukien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DSPhukien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DSPhukien_ItemClick);
            // 
            // btn_LocXe
            // 
            this.btn_LocXe.Caption = "Tìm kiếm xe";
            this.btn_LocXe.Id = 13;
            this.btn_LocXe.Name = "btn_LocXe";
            // 
            // btn_LocPhukien
            // 
            this.btn_LocPhukien.Caption = "Tìm kiếm phụ kiện";
            this.btn_LocPhukien.Id = 14;
            this.btn_LocPhukien.Name = "btn_LocPhukien";
            // 
            // btn_LocThanhphan
            // 
            this.btn_LocThanhphan.Caption = "Lọc thành phần";
            this.btn_LocThanhphan.Id = 15;
            this.btn_LocThanhphan.Name = "btn_LocThanhphan";
            // 
            // btn_helpchucnang
            // 
            this.btn_helpchucnang.Caption = "Hướng dẫn chức năng";
            this.btn_helpchucnang.Id = 16;
            this.btn_helpchucnang.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.direction;
            this.btn_helpchucnang.Name = "btn_helpchucnang";
            this.btn_helpchucnang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_helpchucnang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_helpchucnang_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_Contact
            // 
            this.btn_Contact.Caption = "Liên hệ";
            this.btn_Contact.Id = 18;
            this.btn_Contact.ImageOptions.Image = global::QuanlyNhaMay.Properties.Resources.contact_mail;
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Contact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Contact_ItemClick);
            // 
            // ribbon_Hethong
            // 
            this.ribbon_Hethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbon_Hethong.ImageOptions.Alignment = DevExpress.Utils.HorzAlignment.Center;
            this.ribbon_Hethong.Name = "ribbon_Hethong";
            this.ribbon_Hethong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_gioithieu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Taikhoan);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbon_Danhmuc
            // 
            this.ribbon_Danhmuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbon_Danhmuc.Name = "ribbon_Danhmuc";
            this.ribbon_Danhmuc.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Xe);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Tho);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NuocSX);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Phukien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Phancong);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Thanhphan);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbon_InAn
            // 
            this.ribbon_InAn.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbon_InAn.Name = "ribbon_InAn";
            this.ribbon_InAn.Text = "In/ Ấn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_DSXe);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_DSPhukien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_hoadon);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbon_Help
            // 
            this.ribbon_Help.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbon_Help.Name = "ribbon_Help";
            this.ribbon_Help.Text = "Help";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_helpchucnang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Contact);
            this.ribbonPageGroup5.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanlyNhaMay.Properties.Resources.Khanhminh;
            this.ClientSize = new System.Drawing.Size(1091, 553);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::QuanlyNhaMay.Properties.Resources._1;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_Hethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btn_gioithieu;
        private DevExpress.XtraBars.BarButtonItem btn_Taikhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_Danhmuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_Xe;
        private DevExpress.XtraBars.BarButtonItem btn_Tho;
        private DevExpress.XtraBars.BarButtonItem btn_NuocSX;
        private DevExpress.XtraBars.BarButtonItem btn_Phukien;
        private DevExpress.XtraBars.BarButtonItem btn_Phancong;
        private DevExpress.XtraBars.BarButtonItem btn_Thanhphan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_InAn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_DSXe;
        private DevExpress.XtraBars.BarButtonItem btn_hoadon;
        private DevExpress.XtraBars.BarButtonItem btn_DSPhukien;
        private DevExpress.XtraBars.BarButtonItem btn_LocXe;
        private DevExpress.XtraBars.BarButtonItem btn_LocPhukien;
        private DevExpress.XtraBars.BarButtonItem btn_LocThanhphan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_Help;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_helpchucnang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_Contact;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

