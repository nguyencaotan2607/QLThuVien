
namespace QLThuVien
{
    partial class FChiTietPhieuMuon
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDG = new System.Windows.Forms.ComboBox();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.cbNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgaylap.AutoSize = true;
            this.lbNgaylap.Location = new System.Drawing.Point(412, 59);
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
            this.lbManhanvien.Size = new System.Drawing.Size(97, 16);
            this.lbManhanvien.TabIndex = 59;
            this.lbManhanvien.Text = "Tên Nhân Viên:";
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
            this.btXoa.Location = new System.Drawing.Point(468, 221);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(178, 33);
            this.btXoa.TabIndex = 64;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(274, 221);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(166, 33);
            this.btSua.TabIndex = 65;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(92, 221);
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
            this.lbPhieumuon.Text = "CHI TIẾT PHIẾU MƯỢN";
            this.lbPhieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPhieuMuon
            // 
            this.dgPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuMuon.Location = new System.Drawing.Point(12, 284);
            this.dgPhieuMuon.Name = "dgPhieuMuon";
            this.dgPhieuMuon.RowHeadersWidth = 51;
            this.dgPhieuMuon.RowTemplate.Height = 24;
            this.dgPhieuMuon.Size = new System.Drawing.Size(866, 214);
            this.dgPhieuMuon.TabIndex = 74;
            this.dgPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuMuon_CellClick);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(176, 53);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(137, 23);
            this.txtMaPhieu.TabIndex = 75;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(677, 221);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 33);
            this.btnThoat.TabIndex = 78;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(562, 53);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(293, 23);
            this.dtpNgayLapPhieu.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Tên Độc Giả:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tên Sách:";
            // 
            // cbDG
            // 
            this.cbDG.FormattingEnabled = true;
            this.cbDG.Location = new System.Drawing.Point(176, 149);
            this.cbDG.Name = "cbDG";
            this.cbDG.Size = new System.Drawing.Size(137, 24);
            this.cbDG.TabIndex = 82;
            // 
            // cbSach
            // 
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(562, 98);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(293, 24);
            this.cbSach.TabIndex = 82;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(176, 102);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(137, 24);
            this.cbNV.TabIndex = 82;
            // 
            // FChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.cbSach);
            this.Controls.Add(this.cbDG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayLapPhieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.dgPhieuMuon);
            this.Controls.Add(this.lbManhanvien);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.lbPhieumuon);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.lbNgaylap);
            this.Controls.Add(this.lbMaphieu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FChiTietPhieuMuon";
            this.Text = "frmCTPM";
            this.Load += new System.EventHandler(this.FChiTietPhieuMuon_Load);
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
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDG;
        private System.Windows.Forms.ComboBox cbSach;
        private System.Windows.Forms.ComboBox cbNV;
    }
}