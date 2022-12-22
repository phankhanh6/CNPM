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
    public partial class frmNuocSanXuat : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frmNuocSanXuat()
        {
            InitializeComponent();
        }

        private void frmNuocSanXuat_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tNuocSXBindingSource.DataSource = db.tNuocSX.ToList();
            txt_manuoc.Text = txt_tennuoc.Text = "";
        }
        public void getdata()
        {
            tNuocSXBindingSource.DataSource = db.tNuocSX.ToList();

        }
        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tNuocSXBindingSource.AddNew();
            txt_manuoc.Focus();
        }
        public void Add()
        {
            var newNuoc = new tNuocSX();
            newNuoc.manuoc = txt_manuoc.Text.Trim();
            newNuoc.tennuoc = txt_tennuoc.Text.Trim();
            //newNuoc.bactho = txt_bactho.Text.Trim();


            db.tNuocSX.Add(newNuoc);
            db.SaveChanges();

        }
        public void Update()
        {
            var nuoc = (from t in db.tNuocSX where t.manuoc == txt_manuoc.Text select t).SingleOrDefault();
            tNuocSX newNuoc = db.tNuocSX.FirstOrDefault(c => c.manuoc.Contains(txt_manuoc.Text));

            newNuoc.manuoc = txt_manuoc.Text.Trim();
            newNuoc.tennuoc = txt_tennuoc.Text.Trim();
            //newNuoc.bactho = txt_bactho.Text.Trim();

            db.SaveChanges();

        }
        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var nuoc = db.tPhuKien.FirstOrDefault(x => x.manuoc.Contains(txt_manuoc.Text));
                if (nuoc != null)
                {
                    XtraMessageBox.Show("Dữ liệu không thể xóa do có liên kết");
                }
                else
                {
                    var s = (from t in db.tNuocSX where t.manuoc == txt_manuoc.Text select t).SingleOrDefault();
                    db.tNuocSX.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_manuoc.Text != "")
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
            tNuocSXBindingSource.DataSource = db.tNuocSX.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
                txt_manuoc.ReadOnly = true;
                btn_xoa.Enabled = true;
                opt = true;
        }
    }
}