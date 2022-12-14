using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace QuanLyPX
{
    public  partial class DSXe : Form
    {
        PhanXuongEntities data = new PhanXuongEntities();
        private string maXe;
        private string tenXe;
        private string ghiChu;

        public DSXe()
        {
            InitializeComponent();
        }
        private void DSXe_Load(object sender, EventArgs e)
        {
            //// KHAI BÁO ĐỐI TƯỢNG CONNECTION
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"metadata = res://*/QLPX.csdl|res://*/QLPX.ssdl|res://*/QLPX.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-61E3QUA\SQLEXPRESS;initial catalog=PhanXuong;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" ;
            //con.Open();

            ////CÂU LỆNH TRUY VẤN 
            //String sql = "SELECT * FROM tbltXE";
            //DataSet ds = new DataSet();
            //SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            //dap.Fill(ds);
            //// gắn dữ liệu lên datagridview
            //dgvXe.DataSource = ds.Tables[0];
            //dgvXe.Refresh();
            loadData();
        }

        void loadData()
        {
            int i = 0;
            List<tXe> lstXe = data.tXes.ToList();
            var colums = from t in lstXe
                         orderby t.maxe
                         select new
                         {
                             No = ++i,
                             maxe = t.maxe,
                             tenxe = t.tenxe,
                             ghichu = t.ghichu
                         };
            dgvXe.DataSource = colums.ToList();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            var k = new tXe
            {
                maxe = tb_maXe.Text.Trim(),
                tenxe = tb_tenXe.Text.Trim(),
                ghichu = tb_ghiChu.Text.Trim()
            };
            data.tXes.add(k);
            data.SaveChanges();
            //dgvXe.DataSource = data.tXe.ToList();

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
