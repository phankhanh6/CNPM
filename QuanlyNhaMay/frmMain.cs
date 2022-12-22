using DevExpress.XtraGrid;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanlyNhaMay
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm

    {
        public frmMain()
        {
            InitializeComponent();
            

        }

        private void btn_Xe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXe xe =  new frmXe();
            xe.MdiParent = this;
            xe.Show();
        }

        private void btn_Taikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //if (frmTaiKhoan.isActive())
            //    Application.Exit();
        }

        private void btn_Tho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTho  tho = new frmTho();
            tho.MdiParent = this;
            tho.Show();
        }

        private void btn_NuocSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNuocSanXuat  n = new frmNuocSanXuat();
            n.MdiParent = this;
            n.Show();

        }   

        private void btn_Phukien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhuKien  pk = new frmPhuKien();
            pk.MdiParent = this;
            pk.Show();
        
        }

        private void btn_Phancong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanCong pc = new frmPhanCong();
            pc.MdiParent = this;
            pc.Show();
        }

        private void btn_Thanhphan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThanhPhan tp = new frmThanhPhan();
            tp.MdiParent = this;
            tp.Show();
        }

        private void btn_trangchu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGioithieu tc = new frmGioithieu();
            tc.MdiParent = this;
            tc.Show();
        }

        private void btn_DSXe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_dsXe ds = new frm_dsXe();
            ds.MdiParent = this;
            ds.Show();
            //DocumentViewer documentViewer = new DocumentViewer();
            //GridControl g1 = new GridControl();
            //report.InitData();
            //g1.DataSource = report;

            //rp_Xe report = new rp_Xe();
            //report.ShowPreviewDialog();
        }

        private void btn_DSPhukien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_dsPhukien ds = new frm_dsPhukien();
            ds.MdiParent = this;
            ds.Show();
        }

        private void btn_hoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Hoadon ds = new frm_Hoadon();
            ds.MdiParent = this;
            ds.Show();
        }
    }
}
