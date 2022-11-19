
namespace QLThuVien
{
    partial class QLPhieuMuon
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
            this.lbNgaylap = new System.Windows.Forms.Label();
            this.lbManhanvien = new System.Windows.Forms.Label();
            this.lbMaphieu = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbPhieumuon = new System.Windows.Forms.Label();
            this.dgPhieuMuon = new System.Windows.Forms.DataGridView();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.cbNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgaylap.AutoSize = true;
            this.lbNgaylap.Location = new System.Drawing.Point(21, 151);
            this.lbNgaylap.Name = "lbNgaylap";
            this.lbNgaylap.Size = new System.Drawing.Size(100, 16);
            this.lbNgaylap.TabIndex = 58;
            this.lbNgaylap.Text = "Ngày Lập Phiếu:";
            // 
            // lbManhanvien
            // 
            this.lbManhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManhanvien.AutoSize = true;
            this.lbManhanvien.Location = new System.Drawing.Point(21, 105);
            this.lbManhanvien.Name = "lbManhanvien";
            this.lbManhanvien.Size = new System.Drawing.Size(66, 16);
            this.lbManhanvien.TabIndex = 59;
            this.lbManhanvien.Text = "Nhân Viên";
            // 
            // lbMaphieu
            // 
            this.lbMaphieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaphieu.AutoSize = true;
            this.lbMaphieu.Location = new System.Drawing.Point(21, 59);
            this.lbMaphieu.Name = "lbMaphieu";
            this.lbMaphieu.Size = new System.Drawing.Size(65, 16);
            this.lbMaphieu.TabIndex = 61;
            this.lbMaphieu.Text = "Mã Phiếu:";
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Location = new System.Drawing.Point(443, 200);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(178, 33);
            this.btXoa.TabIndex = 64;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(249, 200);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(166, 33);
            this.btSua.TabIndex = 65;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(67, 200);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(166, 33);
            this.btThem.TabIndex = 67;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbPhieumuon
            // 
            this.lbPhieumuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhieumuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPhieumuon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPhieumuon.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbPhieumuon.Location = new System.Drawing.Point(0, 0);
            this.lbPhieumuon.Name = "lbPhieumuon";
            this.lbPhieumuon.Size = new System.Drawing.Size(890, 38);
            this.lbPhieumuon.TabIndex = 57;
            this.lbPhieumuon.Text = "QUẢN LÝ PHIẾU MƯỢN";
            this.lbPhieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPhieuMuon
            // 
            this.dgPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuMuon.Location = new System.Drawing.Point(12, 289);
            this.dgPhieuMuon.Name = "dgPhieuMuon";
            this.dgPhieuMuon.RowHeadersWidth = 51;
            this.dgPhieuMuon.RowTemplate.Height = 24;
            this.dgPhieuMuon.Size = new System.Drawing.Size(866, 214);
            this.dgPhieuMuon.TabIndex = 74;
            this.dgPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuMuon_CellClick);
            this.dgPhieuMuon.DoubleClick += new System.EventHandler(this.dgPhieuMuon_DoubleClick);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(176, 53);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(137, 23);
            this.txtMaPhieu.TabIndex = 75;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroVe.Location = new System.Drawing.Point(652, 200);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(178, 33);
            this.btnTroVe.TabIndex = 78;
            this.btnTroVe.Text = "&Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(176, 145);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(293, 23);
            this.dtpNgayLapPhieu.TabIndex = 79;
            // 
            // btnTK
            // 
            this.btnTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTK.Location = new System.Drawing.Point(347, 250);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(166, 33);
            this.btnTK.TabIndex = 65;
            this.btnTK.Text = "&Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(176, 105);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(137, 24);
            this.cbNV.TabIndex = 80;
            // 
            // QLPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.dtpNgayLapPhieu);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.dgPhieuMuon);
            this.Controls.Add(this.lbManhanvien);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.lbPhieumuon);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.lbNgaylap);
            this.Controls.Add(this.lbMaphieu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLPhieuMuon";
            this.Text = "frmPM";
            this.Load += new System.EventHandler(this.QLPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNgaylap;
        private System.Windows.Forms.Label lbManhanvien;
        private System.Windows.Forms.Label lbMaphieu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbPhieumuon;
        private System.Windows.Forms.DataGridView dgPhieuMuon;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ComboBox cbNV;
    }
}