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
    public partial class frm_Hoadon : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frm_Hoadon()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tThanhPhanBindingSource.DataSource = db.tThanhPhan.ToList();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            rp_HoaDon report = new rp_HoaDon();
            report.ShowPreviewDialog();
        }
    }
}