using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QuanlyNhaMay
{
    public partial class rp_Xe : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_Xe()
        {
            InitializeComponent();
        }
        public void InitData(List<tXe> data)
        {  
            objectDataSource1.DataSource = data;
        }
    }
}
