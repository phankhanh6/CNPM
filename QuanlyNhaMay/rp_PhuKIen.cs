using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QuanlyNhaMay
{
    public partial class rp_PhuKien : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_PhuKien()
        {
            InitializeComponent();
        }
        public void InitData(List<tPhuKien> data)
        {
            objectDataSource1.DataSource = data;
        }
    }
}
