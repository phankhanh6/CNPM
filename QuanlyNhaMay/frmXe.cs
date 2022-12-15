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
    public partial class frmXe : DevExpress.XtraEditors.XtraForm
    {
        PhanXuongEntities db = new PhanXuongEntities();
        bool opt;
        public frmXe()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt1.Text = ""; 
            txt_1.Text =  "";
            txt_ghichu.Text = "";
            txt_tenxe.Text = "";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void getdata()
        {
            tXeBindingSource.DataSource = db.tXe.ToList();

        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_luu.Enabled = false;
            tXeBindingSource.DataSource = db.tXe.ToList();
            txt1.Text = txt_ghichu.Text = txt_1.Text = txt_tenxe.Text = "";

        }

        private void btn__them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_luu.Enabled = true;
            opt = false;
            tXeBindingSource.AddNew();
            txt1.Focus();   
        }
        public void Add()
        {
            var newXe = new tXe();
            newXe.maxe = txt_maxe.Text.Trim();
            newXe.tenxe = txt_tenxe.Text.Trim();
            newXe.ghichu = txt_ghichu.Text.Trim();


            db.tXe.Add(newXe);
            db.SaveChanges();

        }
        public void Update()
        {
            var xe = (from t in db.tXe where t.maxe == txt_1.Text select t).SingleOrDefault();
            tXe newXe = db.tXe.FirstOrDefault(c => c.maxe.Contains( txt_1.Text));

            newXe.maxe = txt_maxe.Text.Trim();
            newXe.maxe = txt_tenxe.Text.Trim();
            newXe.ghichu = txt_ghichu.Text.Trim();

            db.SaveChanges();

        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txt_maxe.Text != "" )
            {
                if(opt == false)
                {
                    Add();
                }
                else
                {
                    Update();
                }

                getdata();
                XtraMessageBox.Show("Dữ liệu đã được lưu!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Mã xe không được để trống!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_huy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            opt = false;
            txt_1.ReadOnly = false;
            btn_xoa.Enabled = false;
            clear();
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                var xe = db.tPhanCong.FirstOrDefault(x => x.maxe.Contains(txt_1.Text));
                if(xe != null)
                {
                    XtraMessageBox.Show("Dữ liệu không thể xóa do có liên kết");
                }
                else
                {
                    var s = (from t in db.tXe where t.maxe == txt_1.Text select t).SingleOrDefault();
                    db.tXe.Remove(s);
                    db.SaveChanges();
                    getdata();
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txt_1.ReadOnly = true;
            btn_xoa.Enabled = true;
            opt = true;
        }
    }
}