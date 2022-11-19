
namespace QLThuVien
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btQLsach = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btQLnhanvien = new System.Windows.Forms.Button();
            this.btQLdocgia = new System.Windows.Forms.Button();
            this.btQLphieumuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLThuVien.Properties.Resources.K_S_ch_G_Ch_p_nh_Ph_ng_N_n_Th_Vi_n_S_ch_png_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQLsach
            // 
            this.btQLsach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLsach.Location = new System.Drawing.Point(296, 147);
            this.btQLsach.Name = "btQLsach";
            this.btQLsach.Size = new System.Drawing.Size(230, 41);
            this.btQLsach.TabIndex = 2;
            this.btQLsach.Text = "Quản Lý Sách";
            this.btQLsach.UseVisualStyleBackColor = false;
            this.btQLsach.Click += new System.EventHandler(this.btQLsach_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLThuVien.Properties.Resources.K_S_ch_G_Ch_p_nh_Ph_ng_N_n_Th_Vi_n_S_ch_png_;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(821, 447);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.SystemColors.Info;
            this.btDangXuat.Location = new System.Drawing.Point(675, 12);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(120, 42);
            this.btDangXuat.TabIndex = 3;
            this.btDangXuat.Text = "Đăng Xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btQLnhanvien
            // 
            this.btQLnhanvien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLnhanvien.Location = new System.Drawing.Point(293, 228);
            this.btQLnhanvien.Name = "btQLnhanvien";
            this.btQLnhanvien.Size = new System.Drawing.Size(230, 41);
            this.btQLnhanvien.TabIndex = 2;
            this.btQLnhanvien.Text = "Quản Lý Nhân Viên";
            this.btQLnhanvien.UseVisualStyleBackColor = false;
            this.btQLnhanvien.Click += new System.EventHandler(this.btQLnhanvien_Click);
            // 
            // btQLdocgia
            // 
            this.btQLdocgia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLdocgia.Location = new System.Drawing.Point(293, 301);
            this.btQLdocgia.Name = "btQLdocgia";
            this.btQLdocgia.Size = new System.Drawing.Size(230, 41);
            this.btQLdocgia.TabIndex = 2;
            this.btQLdocgia.Text = "Quản Lý Độc Giả";
            this.btQLdocgia.UseVisualStyleBackColor = false;
            this.btQLdocgia.Click += new System.EventHandler(this.btQLdocgia_Click);
            // 
            // btQLphieumuon
            // 
            this.btQLphieumuon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btQLphieumuon.Location = new System.Drawing.Point(293, 375);
            this.btQLphieumuon.Name = "btQLphieumuon";
            this.btQLphieumuon.Size = new System.Drawing.Size(230, 41);
            this.btQLphieumuon.TabIndex = 2;
            this.btQLphieumuon.Text = "Quản Lý Phiếu Mượn";
            this.btQLphieumuon.UseVisualStyleBackColor = false;
            this.btQLphieumuon.Click += new System.EventHandler(this.btQLphieumuon_Click);
            // 
            // QuanLy
            // 
            this.ClientSize = new System.Drawing.Size(822, 451);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.btQLphieumuon);
            this.Controls.Add(this.btQLdocgia);
            this.Controls.Add(this.btQLnhanvien);
            this.Controls.Add(this.btQLsach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLy";
            this.Text = "Quản Lý";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQLsach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btQLnhanvien;
        private System.Windows.Forms.Button btQLdocgia;
        private System.Windows.Forms.Button btQLphieumuon;
    }
}