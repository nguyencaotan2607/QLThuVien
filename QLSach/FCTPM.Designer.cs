namespace QLSach
{
    partial class FCTPM
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbMadg = new System.Windows.Forms.ComboBox();
            this.lbMaDG = new System.Windows.Forms.Label();
            this.cbMasach = new System.Windows.Forms.ComboBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.cbMaPM = new System.Windows.Forms.ComboBox();
            this.lbNgaylap = new System.Windows.Forms.Label();
            this.lbManhanvien = new System.Windows.Forms.Label();
            this.lbMasach = new System.Windows.Forms.Label();
            this.lbMaphieu = new System.Windows.Forms.Label();
            this.btMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbPhieumuon = new System.Windows.Forms.Label();
            this.dgCTPM = new System.Windows.Forms.DataGridView();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTPM)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgayLapPhieu);
            this.splitContainer1.Panel1.Controls.Add(this.cbMadg);
            this.splitContainer1.Panel1.Controls.Add(this.lbMaDG);
            this.splitContainer1.Panel1.Controls.Add(this.cbMasach);
            this.splitContainer1.Panel1.Controls.Add(this.cbManv);
            this.splitContainer1.Panel1.Controls.Add(this.cbMaPM);
            this.splitContainer1.Panel1.Controls.Add(this.lbNgaylap);
            this.splitContainer1.Panel1.Controls.Add(this.lbManhanvien);
            this.splitContainer1.Panel1.Controls.Add(this.lbMasach);
            this.splitContainer1.Panel1.Controls.Add(this.lbMaphieu);
            this.splitContainer1.Panel1.Controls.Add(this.btMoi);
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            this.splitContainer1.Panel1.Controls.Add(this.btThem);
            this.splitContainer1.Panel1.Controls.Add(this.lbPhieumuon);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgCTPM);
            this.splitContainer1.Size = new System.Drawing.Size(766, 519);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbMadg
            // 
            this.cbMadg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMadg.FormattingEnabled = true;
            this.cbMadg.Location = new System.Drawing.Point(108, 147);
            this.cbMadg.Name = "cbMadg";
            this.cbMadg.Size = new System.Drawing.Size(248, 24);
            this.cbMadg.TabIndex = 69;
            this.cbMadg.SelectedIndexChanged += new System.EventHandler(this.cbMadg_SelectedIndexChanged);
            // 
            // lbMaDG
            // 
            this.lbMaDG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaDG.AutoSize = true;
            this.lbMaDG.Location = new System.Drawing.Point(13, 150);
            this.lbMaDG.Name = "lbMaDG";
            this.lbMaDG.Size = new System.Drawing.Size(75, 16);
            this.lbMaDG.TabIndex = 63;
            this.lbMaDG.Text = "Mã độc giả:";
            // 
            // cbMasach
            // 
            this.cbMasach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMasach.FormattingEnabled = true;
            this.cbMasach.Location = new System.Drawing.Point(486, 113);
            this.cbMasach.Name = "cbMasach";
            this.cbMasach.Size = new System.Drawing.Size(268, 24);
            this.cbMasach.TabIndex = 68;
            // 
            // cbManv
            // 
            this.cbManv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(108, 110);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(248, 24);
            this.cbManv.TabIndex = 72;
            // 
            // cbMaPM
            // 
            this.cbMaPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaPM.FormattingEnabled = true;
            this.cbMaPM.Location = new System.Drawing.Point(108, 72);
            this.cbMaPM.Name = "cbMaPM";
            this.cbMaPM.Size = new System.Drawing.Size(248, 24);
            this.cbMaPM.TabIndex = 71;
            // 
            // lbNgaylap
            // 
            this.lbNgaylap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgaylap.AutoSize = true;
            this.lbNgaylap.Location = new System.Drawing.Point(383, 80);
            this.lbNgaylap.Name = "lbNgaylap";
            this.lbNgaylap.Size = new System.Drawing.Size(97, 16);
            this.lbNgaylap.TabIndex = 58;
            this.lbNgaylap.Text = "Ngày lập phiếu:";
            // 
            // lbManhanvien
            // 
            this.lbManhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManhanvien.AutoSize = true;
            this.lbManhanvien.Location = new System.Drawing.Point(13, 113);
            this.lbManhanvien.Name = "lbManhanvien";
            this.lbManhanvien.Size = new System.Drawing.Size(89, 16);
            this.lbManhanvien.TabIndex = 59;
            this.lbManhanvien.Text = "Mã nhân viên:";
            this.lbManhanvien.Click += new System.EventHandler(this.lbManhanvien_Click);
            // 
            // lbMasach
            // 
            this.lbMasach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMasach.AutoSize = true;
            this.lbMasach.Location = new System.Drawing.Point(383, 116);
            this.lbMasach.Name = "lbMasach";
            this.lbMasach.Size = new System.Drawing.Size(60, 16);
            this.lbMasach.TabIndex = 60;
            this.lbMasach.Text = "Mã sách:";
            // 
            // lbMaphieu
            // 
            this.lbMaphieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaphieu.AutoSize = true;
            this.lbMaphieu.Location = new System.Drawing.Point(12, 75);
            this.lbMaphieu.Name = "lbMaphieu";
            this.lbMaphieu.Size = new System.Drawing.Size(65, 16);
            this.lbMaphieu.TabIndex = 61;
            this.lbMaphieu.Text = "Mã phiếu:";
            // 
            // btMoi
            // 
            this.btMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMoi.Location = new System.Drawing.Point(108, 215);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(110, 33);
            this.btMoi.TabIndex = 66;
            this.btMoi.Text = "&Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Location = new System.Drawing.Point(638, 215);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(116, 33);
            this.btXoa.TabIndex = 64;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(456, 215);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(112, 33);
            this.btSua.TabIndex = 65;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(279, 215);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 33);
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
            this.lbPhieumuon.Size = new System.Drawing.Size(766, 38);
            this.lbPhieumuon.TabIndex = 57;
            this.lbPhieumuon.Text = "QUẢN LÝ PHIẾU MƯỢN";
            this.lbPhieumuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPhieumuon.Click += new System.EventHandler(this.lbPhieumuon_Click);
            // 
            // dgCTPM
            // 
            this.dgCTPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCTPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTPM.Location = new System.Drawing.Point(8, 8);
            this.dgCTPM.Name = "dgCTPM";
            this.dgCTPM.Size = new System.Drawing.Size(750, 198);
            this.dgCTPM.TabIndex = 1;
            this.dgCTPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTPM_CellClick);
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(486, 75);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(268, 23);
            this.dtpNgayLapPhieu.TabIndex = 73;
            // 
            // FCTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 519);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FCTPM";
            this.Text = "frmCTPM";
            this.Load += new System.EventHandler(this.FCTPM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCTPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbMadg;
        private System.Windows.Forms.Label lbMaDG;
        private System.Windows.Forms.ComboBox cbMasach;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.ComboBox cbMaPM;
        private System.Windows.Forms.Label lbNgaylap;
        private System.Windows.Forms.Label lbManhanvien;
        private System.Windows.Forms.Label lbMasach;
        private System.Windows.Forms.Label lbMaphieu;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbPhieumuon;
        private System.Windows.Forms.DataGridView dgCTPM;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
    }
}