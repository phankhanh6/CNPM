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
    public partial class frmTho : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;

        public frmTho()
        {
            InitializeComponent();
        }

        private void frmTho_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tThoBindingSource.DataSource = db.tTho.ToList();
            txt_matho.Text = txt_tentho.Text =  txt_bactho.Text = "";

        }
        public void getdata()
        {
            tThoBindingSource.DataSource = db.tTho.ToList();

        }
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tThoBindingSource.AddNew();
            txt_matho.Focus();
        }
        public void Add()
        {
            var newTho = new tTho();
            newTho.matho = txt_matho.Text.Trim();
            newTho.tentho = txt_tentho.Text.Trim();
            newTho.bactho = txt_bactho.Text.Trim();


            db.tTho.Add(newTho);
            db.SaveChanges();

        }
        public void Update()
        {
            var tho = (from t in db.tTho where t.matho == txt_matho.Text select t).SingleOrDefault();
            tTho newTho = db.tTho.FirstOrDefault(c => c.matho.Contains(txt_matho.Text));

            newTho.matho = txt_matho.Text.Trim();
            newTho.tentho = txt_tentho.Text.Trim();
            newTho.bactho = txt_bactho.Text.Trim();

            db.SaveChanges();

        }
        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var tho = db.tPhanCong.FirstOrDefault(x => x.matho.Contains(txt_matho.Text));
                if (tho != null)
                {
                    XtraMessageBox.Show("Dữ liệu không thể xóa do có liên kết");
                }
                else
                {
                    var s = (from t in db.tTho where t.matho == txt_matho.Text select t).SingleOrDefault();
                    db.tTho.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_matho.Text != "")
            {
                if (opt == false)
                {
                    Add();
                }
                else
                {
                    Update();
                }

                getdata();
                XtraMessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Mã xe không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tThoBindingSource.DataSource = db.tTho.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_matho.ReadOnly = true;
            btn_xoa.Enabled = true;
            opt = true;
        }
    }
}