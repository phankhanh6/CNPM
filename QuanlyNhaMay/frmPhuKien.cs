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
    public partial class frmPhuKien : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;

        public frmPhuKien()
        {
            InitializeComponent();
        }

        private void frmPhuKien_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tPhuKienBindingSource.DataSource = db.tPhuKien.ToList();
            txt_maphukien.Text = txt_tenphukien.Text = txt_manuoc.Text = txt_dongia.Text = txt_soluongtontai.Text = txt_ghichu.Text = "";
        }
        public void getdata()
        {
            tPhuKienBindingSource.DataSource = db.tPhuKien.ToList();

        }
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tPhuKienBindingSource.AddNew();
            txt_maphukien.Focus();
        }
        public void Add()
        {
            var newPhuKien = new tPhuKien();
            newPhuKien.mapk = txt_maphukien.Text.Trim();
            newPhuKien.tenpk = txt_tenphukien.Text.Trim();
            newPhuKien.manuoc = txt_manuoc.Text.Trim();
            newPhuKien.dongia = float.Parse(txt_dongia.Text.Trim());//float
            newPhuKien.soluongtontai = Int32.Parse(txt_soluongtontai.Text.Trim());//int
            newPhuKien.ghichu = txt_ghichu.Text.Trim();


            db.tPhuKien.Add(newPhuKien);
            db.SaveChanges();

        }
        public void Update()
        {
            var phukien = (from t in db.tPhuKien where t.manuoc == txt_maphukien.Text select t).SingleOrDefault();
            tPhuKien newPhuKien = db.tPhuKien.FirstOrDefault(c => c.mapk.Contains(txt_maphukien.Text));

            newPhuKien.mapk = txt_maphukien.Text.Trim();
            newPhuKien.tenpk = txt_tenphukien.Text.Trim();
            newPhuKien.manuoc = txt_manuoc.Text.Trim();
            newPhuKien.dongia = float.Parse(txt_dongia.Text.Trim());//float
            newPhuKien.soluongtontai = Int32.Parse(txt_soluongtontai.Text.Trim());//int
            newPhuKien.ghichu = txt_ghichu.Text.Trim();

            db.SaveChanges();

        }
        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var pk = db.tThanhPhan.FirstOrDefault(x => x.mapk.Contains(txt_maphukien.Text));
                if (pk != null)
                {
                    XtraMessageBox.Show("Dữ liệu không thể xóa do có liên kết");
                }
                else
                {
                    var s = (from t in db.tPhuKien where t.mapk == txt_maphukien.Text select t).SingleOrDefault();
                    db.tPhuKien.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_maphukien.Text != "")
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
            tPhuKienBindingSource.DataSource = db.tPhuKien.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = true;
            btn_luu.Enabled = true;
            opt = true;
        }
    }
}