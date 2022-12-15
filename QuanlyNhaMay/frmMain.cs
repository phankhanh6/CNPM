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
            if (frmTaiKhoan.isActive())
                Application.Exit();
        }
    }
}
