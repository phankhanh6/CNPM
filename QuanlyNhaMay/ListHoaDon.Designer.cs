
namespace QuanlyNhaMay
{
    partial class frm_Hoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btn_load = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tThanhPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colmathanhphan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaxe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmapk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltPhuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltXe = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThanhPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btn_in);
            this.layoutControl1.Controls.Add(this.btn_load);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(710, 512);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(710, 512);
            this.Root.TextVisible = false;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(343, 473);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(178, 27);
            this.btn_load.StyleController = this.layoutControl1;
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Hiển thị danh sách hóa đơn";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_load;
            this.layoutControlItem1.Location = new System.Drawing.Point(331, 461);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(182, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 461);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(331, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(525, 473);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(173, 27);
            this.btn_in.StyleController = this.layoutControl1;
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_in;
            this.layoutControlItem2.Location = new System.Drawing.Point(513, 461);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(177, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tThanhPhanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(686, 457);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmathanhphan,
            this.colmaxe,
            this.colmapk,
            this.coldonvitinh,
            this.colsoluong,
            this.coltPhuKien,
            this.coltXe});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(690, 461);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tThanhPhanBindingSource
            // 
            this.tThanhPhanBindingSource.DataSource = typeof(QuanlyNhaMay.tThanhPhan);
            // 
            // colmathanhphan
            // 
            this.colmathanhphan.FieldName = "mathanhphan";
            this.colmathanhphan.MinWidth = 25;
            this.colmathanhphan.Name = "colmathanhphan";
            this.colmathanhphan.Visible = true;
            this.colmathanhphan.VisibleIndex = 0;
            this.colmathanhphan.Width = 94;
            // 
            // colmaxe
            // 
            this.colmaxe.FieldName = "maxe";
            this.colmaxe.MinWidth = 25;
            this.colmaxe.Name = "colmaxe";
            this.colmaxe.Visible = true;
            this.colmaxe.VisibleIndex = 1;
            this.colmaxe.Width = 94;
            // 
            // colmapk
            // 
            this.colmapk.FieldName = "mapk";
            this.colmapk.MinWidth = 25;
            this.colmapk.Name = "colmapk";
            this.colmapk.Visible = true;
            this.colmapk.VisibleIndex = 2;
            this.colmapk.Width = 94;
            // 
            // coldonvitinh
            // 
            this.coldonvitinh.FieldName = "donvitinh";
            this.coldonvitinh.MinWidth = 25;
            this.coldonvitinh.Name = "coldonvitinh";
            this.coldonvitinh.Visible = true;
            this.coldonvitinh.VisibleIndex = 3;
            this.coldonvitinh.Width = 94;
            // 
            // colsoluong
            // 
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.MinWidth = 25;
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 4;
            this.colsoluong.Width = 94;
            // 
            // coltPhuKien
            // 
            this.coltPhuKien.FieldName = "tPhuKien";
            this.coltPhuKien.MinWidth = 25;
            this.coltPhuKien.Name = "coltPhuKien";
            this.coltPhuKien.Visible = true;
            this.coltPhuKien.VisibleIndex = 5;
            this.coltPhuKien.Width = 94;
            // 
            // coltXe
            // 
            this.coltXe.FieldName = "tXe";
            this.coltXe.MinWidth = 25;
            this.coltXe.Name = "coltXe";
            this.coltXe.Visible = true;
            this.coltXe.VisibleIndex = 6;
            this.coltXe.Width = 94;
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 512);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_hoadon";
            this.Text = "Hóa đơn số lượng";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThanhPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_load;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tThanhPhanBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmathanhphan;
        private DevExpress.XtraGrid.Columns.GridColumn colmaxe;
        private DevExpress.XtraGrid.Columns.GridColumn colmapk;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn coltPhuKien;
        private DevExpress.XtraGrid.Columns.GridColumn coltXe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}