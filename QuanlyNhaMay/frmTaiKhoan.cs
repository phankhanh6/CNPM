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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        bool isDone = false;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            return;
        }

        public static bool isActive()
        {
            frmTaiKhoan taiKhoan = new frmTaiKhoan();
            taiKhoan.ShowDialog();
            if (taiKhoan.isDone)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text == string.Empty)
            {
                txt_tk.Select();
                return;
            }
            if (txt_mk.Text == string.Empty)
            {
                txt_mk.Select();
                return;
            }
            if (txt_tk.Text != string.Empty && txt_tk.Text == "khanhminh" && txt_mk.Text != string.Empty && txt_mk.Text == "123")
            {
                isDone = true;
                frmMain main = new frmMain();
                main.ShowDialog();
                Close();

            }
            else isDone = false;
            if (!isDone)
            {
                XtraMessageBox.Show("Error in your infomation", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            isDone = false;
            Close();
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void txt_tk_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}