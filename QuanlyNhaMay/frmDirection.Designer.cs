
namespace QuanlyNhaMay
{
    partial class frm_Direction
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
            this.SuspendLayout();
            // 
            // frm_Direction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::QuanlyNhaMay.Properties.Resources.bg_dangnhap;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.IconOptions.Image = global::QuanlyNhaMay.Properties.Resources.direction;
            this.Name = "frm_Direction";
            this.Text = "Hướng dẫn";
            this.Load += new System.EventHandler(this.frm_Direction_Load);
            this.Click += new System.EventHandler(this.frm_Direction_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}