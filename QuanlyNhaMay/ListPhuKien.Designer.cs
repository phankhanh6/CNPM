
namespace QuanlyNhaMay
{
    partial class frm_dsPhukien
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
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btn_load = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tPhuKienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colmapk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenpk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmanuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluongtontai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colghichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltNuocSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltThanhPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPhuKienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btn_load);
            this.layoutControl1.Controls.Add(this.btn_in);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(785, 530);
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
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(785, 530);
            this.Root.TextVisible = false;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(596, 491);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(177, 27);
            this.btn_in.StyleController = this.layoutControl1;
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_in;
            this.layoutControlItem1.Location = new System.Drawing.Point(584, 479);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(181, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 479);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(405, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(417, 491);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(175, 27);
            this.btn_load.StyleController = this.layoutControl1;
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "Hiển thị danh sách phụ kiện";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_load;
            this.layoutControlItem2.Location = new System.Drawing.Point(405, 479);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tPhuKienBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(761, 475);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmapk,
            this.coltenpk,
            this.colmanuoc,
            this.coldongia,
            this.colsoluongtontai,
            this.colghichu,
            this.coltNuocSX,
            this.coltThanhPhan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(765, 479);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // tPhuKienBindingSource
            // 
            this.tPhuKienBindingSource.DataSource = typeof(QuanlyNhaMay.tPhuKien);
            // 
            // colmapk
            // 
            this.colmapk.FieldName = "mapk";
            this.colmapk.MinWidth = 25;
            this.colmapk.Name = "colmapk";
            this.colmapk.Visible = true;
            this.colmapk.VisibleIndex = 0;
            this.colmapk.Width = 94;
            // 
            // coltenpk
            // 
            this.coltenpk.FieldName = "tenpk";
            this.coltenpk.MinWidth = 25;
            this.coltenpk.Name = "coltenpk";
            this.coltenpk.Visible = true;
            this.coltenpk.VisibleIndex = 1;
            this.coltenpk.Width = 94;
            // 
            // colmanuoc
            // 
            this.colmanuoc.FieldName = "manuoc";
            this.colmanuoc.MinWidth = 25;
            this.colmanuoc.Name = "colmanuoc";
            this.colmanuoc.Visible = true;
            this.colmanuoc.VisibleIndex = 2;
            this.colmanuoc.Width = 94;
            // 
            // coldongia
            // 
            this.coldongia.FieldName = "dongia";
            this.coldongia.MinWidth = 25;
            this.coldongia.Name = "coldongia";
            this.coldongia.Visible = true;
            this.coldongia.VisibleIndex = 3;
            this.coldongia.Width = 94;
            // 
            // colsoluongtontai
            // 
            this.colsoluongtontai.FieldName = "soluongtontai";
            this.colsoluongtontai.MinWidth = 25;
            this.colsoluongtontai.Name = "colsoluongtontai";
            this.colsoluongtontai.Visible = true;
            this.colsoluongtontai.VisibleIndex = 4;
            this.colsoluongtontai.Width = 94;
            // 
            // colghichu
            // 
            this.colghichu.FieldName = "ghichu";
            this.colghichu.MinWidth = 25;
            this.colghichu.Name = "colghichu";
            this.colghichu.Visible = true;
            this.colghichu.VisibleIndex = 5;
            this.colghichu.Width = 94;
            // 
            // coltNuocSX
            // 
            this.coltNuocSX.FieldName = "tNuocSX";
            this.coltNuocSX.MinWidth = 25;
            this.coltNuocSX.Name = "coltNuocSX";
            this.coltNuocSX.Visible = true;
            this.coltNuocSX.VisibleIndex = 6;
            this.coltNuocSX.Width = 94;
            // 
            // coltThanhPhan
            // 
            this.coltThanhPhan.FieldName = "tThanhPhan";
            this.coltThanhPhan.MinWidth = 25;
            this.coltThanhPhan.Name = "coltThanhPhan";
            this.coltThanhPhan.Visible = true;
            this.coltThanhPhan.VisibleIndex = 7;
            this.coltThanhPhan.Width = 94;
            // 
            // frm_dsphukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 530);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_dsphukien";
            this.Text = "Danh sách phụ kiện";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPhuKienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tPhuKienBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmapk;
        private DevExpress.XtraGrid.Columns.GridColumn coltenpk;
        private DevExpress.XtraGrid.Columns.GridColumn colmanuoc;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluongtontai;
        private DevExpress.XtraGrid.Columns.GridColumn colghichu;
        private DevExpress.XtraGrid.Columns.GridColumn coltNuocSX;
        private DevExpress.XtraGrid.Columns.GridColumn coltThanhPhan;
        private DevExpress.XtraEditors.SimpleButton btn_load;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}