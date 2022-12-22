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
    public partial class frmPhanCong : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt; 
        public frmPhanCong()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            tPhanCongBindingSource.DataSource = db.tPhanCong.ToList();

        }
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tPhanCongBindingSource.DataSource = db.tPhanCong.ToList();
            txt_maphancong.Text = txt_maxe.Text = txt_matho.Text = "";
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tPhanCongBindingSource.AddNew();
            txt_maphancong.Focus();
        }
        public void Add()
        {
            var newPhanCong = new tPhanCong();
            newPhanCong.maphancong = txt_maphancong.Text.Trim();
            newPhanCong.matho = txt_matho.Text.Trim();
            newPhanCong.maxe = txt_maxe.Text.Trim();


            db.tPhanCong.Add(newPhanCong);
            db.SaveChanges();

        }
        public void Update()
        {
            var phancong = (from t in db.tPhanCong where t.maphancong == txt_maphancong.Text select t).SingleOrDefault();
            tPhanCong newPhanCong = db.tPhanCong.FirstOrDefault(c => c.maphancong.Contains(txt_maphancong.Text));

            newPhanCong.maphancong = txt_maphancong.Text.Trim();
            newPhanCong.matho = txt_matho.Text.Trim();
            newPhanCong.maxe = txt_maxe.Text.Trim();

            db.SaveChanges();

        }
        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var pc = db.tXe.FirstOrDefault(x => x.maxe.Contains(txt_maxe.Text));
                if (pc != null)
                {
                    XtraMessageBox.Show("Dữ liệu không thể xóa do có liên kết");
                }
                else
                {
                    var s = (from t in db.tPhanCong where t.maphancong == txt_maphancong.Text select t).SingleOrDefault();
                    db.tPhanCong.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_maphancong.Text != "")
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
            tPhanCongBindingSource.DataSource = db.tPhanCong.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_maphancong.ReadOnly = true;
            btn_xoa.Enabled = true;
            opt = true;
        }
    }
}