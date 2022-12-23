using DevExpress.XtraEditors;
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
    public partial class frm_Direction : DevExpress.XtraEditors.XtraForm
    {
        public frm_Direction()
        {
            InitializeComponent();
        }

        private void frm_Direction_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://www.facebook.com/groups/phanmemquanlybh");

        }
        private void frm_Direction_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/phanmemquanlybh");

        }
    }
}