using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyNhaMay
{
    public partial class frm_dsPhukien : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frm_dsPhukien()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tPhuKienBindingSource.DataSource = db.tPhuKien.ToList();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            rp_PhuKien report = new rp_PhuKien();
            report.ShowPreviewDialog();
        }
    }
}