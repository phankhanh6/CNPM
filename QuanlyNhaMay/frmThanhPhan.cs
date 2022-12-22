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
    public partial class frmThanhPhan : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frmThanhPhan()
        {
            InitializeComponent();
        }
        public void getdata()
        {
            tThanhPhanBindingSource.DataSource = db.tThanhPhan.ToList();

        }
        private void frmThanhPhan_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tThanhPhanBindingSource.DataSource = db.tThanhPhan.ToList();
            txt_maphukien.Text = txt_maxe.Text = txt_mathanhphan.Text = txt_soluong.Text = txt_donvitinh.Text = "";
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tThanhPhanBindingSource.AddNew();
            txt_mathanhphan.Focus();
        }
        public void Add()
        {
            var newThanhPhan = new tThanhPhan();
            newThanhPhan.mathanhphan = txt_mathanhphan.Text.Trim();
            newThanhPhan.maxe = txt_maxe.Text.Trim();
            newThanhPhan.mapk = txt_maphukien.Text.Trim();
            newThanhPhan.donvitinh = txt_donvitinh.Text.Trim();
            newThanhPhan.soluong = Int32.Parse(txt_soluong.Text.Trim());


            db.tThanhPhan.Add(newThanhPhan);
            db.SaveChanges();

        }
        public void Update()
        {
            var phancong = (from t in db.tPhanCong where t.maphancong == txt_mathanhphan.Text select t).SingleOrDefault();
            tThanhPhan newThanhPhan = db.tThanhPhan.FirstOrDefault(c => c.mathanhphan.Contains(txt_mathanhphan.Text));

            newThanhPhan.mathanhphan = txt_mathanhphan.Text.Trim();
            newThanhPhan.maxe = txt_maxe.Text.Trim();
            newThanhPhan.mapk = txt_maphukien.Text.Trim();
            newThanhPhan.donvitinh = txt_donvitinh.Text.Trim();
            newThanhPhan.soluong = Int32.Parse(txt_soluong.Text.Trim());

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
                    var s = (from t in db.tThanhPhan where t.mathanhphan == txt_mathanhphan.Text select t).SingleOrDefault();
                    db.tThanhPhan.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_mathanhphan.Text != "")
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
            tThanhPhanBindingSource.DataSource = db.tThanhPhan.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_mathanhphan.ReadOnly = true;
            btn_xoa.Enabled = true;
            opt = true;
        }
    }
}