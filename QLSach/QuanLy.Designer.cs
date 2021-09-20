
namespace QLSach
{
    partial class QuanLy
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.quanLySachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDocGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyCTPhieuMuonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySachToolStripMenuItem,
            this.quanLyNhanVienToolStripMenuItem,
            this.quanLyDocGiaToolStripMenuItem,
            this.quanLyCTPhieuMuonToolStripMenuItem,
            this.quanLyThoatToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // quanLySachToolStripMenuItem
            // 
            this.quanLySachToolStripMenuItem.Name = "quanLySachToolStripMenuItem";
            this.quanLySachToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.quanLySachToolStripMenuItem.Text = "Quản lý Sách";
            this.quanLySachToolStripMenuItem.Click += new System.EventHandler(this.quanLySachToolStripMenuItem_Click);
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản lý Nhân Viên";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // quanLyDocGiaToolStripMenuItem
            // 
            this.quanLyDocGiaToolStripMenuItem.Name = "quanLyDocGiaToolStripMenuItem";
            this.quanLyDocGiaToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.quanLyDocGiaToolStripMenuItem.Text = "Quản lý Độc Giả";
            // 
            // quanLyCTPhieuMuonToolStripMenuItem
            // 
            this.quanLyCTPhieuMuonToolStripMenuItem.Name = "quanLyCTPhieuMuonToolStripMenuItem";
            this.quanLyCTPhieuMuonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.quanLyCTPhieuMuonToolStripMenuItem.Text = "Quản lý Chi Tiết Phiếu Mượn";
            // 
            // quanLyThoatToolStripMenuItem
            // 
            this.quanLyThoatToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.quanLyThoatToolStripMenuItem.Name = "quanLyThoatToolStripMenuItem";
            this.quanLyThoatToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.quanLyThoatToolStripMenuItem.Text = "Thoát";
            this.quanLyThoatToolStripMenuItem.Click += new System.EventHandler(this.quanLyThoatToolStripMenuItem_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem quanLySachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDocGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyCTPhieuMuonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyThoatToolStripMenuItem;
    }
}