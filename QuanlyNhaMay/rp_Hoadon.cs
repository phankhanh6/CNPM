using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QuanlyNhaMay
{
    public partial class rp_HoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_HoaDon()
        {
            InitializeComponent();
        }
        public void InitData(List<tThanhPhan> data)
        {
            objectDataSource1.DataSource = data;
        }
    }
}
