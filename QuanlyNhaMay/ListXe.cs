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
    public partial class frm_dsXe : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frm_dsXe()
        {
            InitializeComponent();
        }

        private void frm_dsXe_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tXeBindingSource.DataSource = db.tXe.ToList();

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            rp_Xe report = new rp_Xe();
            report.ShowPreviewDialog();
        }
    }
}