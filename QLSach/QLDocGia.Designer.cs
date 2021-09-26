using System;
namespace QLSach
{
    partial class QLDocGia
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
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNTT = new System.Windows.Forms.DateTimePicker();
            this.btTV = new System.Windows.Forms.Button();
            this.btBC = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbDocgia = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMadg = new System.Windows.Forms.TextBox();
            this.txtTendg = new System.Windows.Forms.TextBox();
            this.lbNgaytaothe = new System.Windows.Forms.Label();
            this.lbMadg = new System.Windows.Forms.Label();
            this.lbNamsinh = new System.Windows.Forms.Label();
            this.lbTendg = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbManv = new System.Windows.Forms.Label();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.dgDocgia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpNamSinh);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNTT);
            this.splitContainer1.Panel1.Controls.Add(this.btTV);
            this.splitContainer1.Panel1.Controls.Add(this.btBC);
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            this.splitContainer1.Panel1.Controls.Add(this.btThem);
            this.splitContainer1.Panel1.Controls.Add(this.lbDocgia);
            this.splitContainer1.Panel1.Controls.Add(this.cbNV);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiachi);
            this.splitContainer1.Panel1.Controls.Add(this.lbDiachi);
            this.splitContainer1.Panel1.Controls.Add(this.txtGT);
            this.splitContainer1.Panel1.Controls.Add(this.txtLop);
            this.splitContainer1.Panel1.Controls.Add(this.txtMadg);
            this.splitContainer1.Panel1.Controls.Add(this.txtTendg);
            this.splitContainer1.Panel1.Controls.Add(this.lbNgaytaothe);
            this.splitContainer1.Panel1.Controls.Add(this.lbMadg);
            this.splitContainer1.Panel1.Controls.Add(this.lbNamsinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbTendg);
            this.splitContainer1.Panel1.Controls.Add(this.lbLop);
            this.splitContainer1.Panel1.Controls.Add(this.lbManv);
            this.splitContainer1.Panel1.Controls.Add(this.lbGioitinh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDocgia);
            this.splitContainer1.Size = new System.Drawing.Size(555, 400);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSinh.Location = new System.Drawing.Point(400, 125);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(139, 23);
            this.dtpNamSinh.TabIndex = 62;
            // 
            // dtpNTT
            // 
            this.dtpNTT.CustomFormat = "dd/MM/yyyy";
            this.dtpNTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNTT.Location = new System.Drawing.Point(400, 91);
            this.dtpNTT.Name = "dtpNTT";
            this.dtpNTT.Size = new System.Drawing.Size(139, 23);
            this.dtpNTT.TabIndex = 62;
            // 
            // btTV
            // 
            this.btTV.Location = new System.Drawing.Point(31, 184);
            this.btTV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTV.Name = "btTV";
            this.btTV.Size = new System.Drawing.Size(88, 30);
            this.btTV.TabIndex = 60;
            this.btTV.Text = "Trở về";
            this.btTV.UseVisualStyleBackColor = true;
            this.btTV.Click += new System.EventHandler(this.btTV_Click);
            // 
            // btBC
            // 
            this.btBC.Location = new System.Drawing.Point(136, 184);
            this.btBC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBC.Name = "btBC";
            this.btBC.Size = new System.Drawing.Size(88, 30);
            this.btBC.TabIndex = 60;
            this.btBC.Text = "Báo cáo";
            this.btBC.UseVisualStyleBackColor = true;
            this.btBC.Click += new System.EventHandler(this.btBC_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(448, 184);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 32);
            this.btXoa.TabIndex = 58;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(344, 184);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 32);
            this.btSua.TabIndex = 59;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(240, 184);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 32);
            this.btThem.TabIndex = 61;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // lbDocgia
            // 
            this.lbDocgia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDocgia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDocgia.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbDocgia.Location = new System.Drawing.Point(0, 0);
            this.lbDocgia.Name = "lbDocgia";
            this.lbDocgia.Size = new System.Drawing.Size(555, 47);
            this.lbDocgia.TabIndex = 37;
            this.lbDocgia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.lbDocgia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(80, 120);
            this.cbNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(83, 24);
            this.cbNV.TabIndex = 53;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(80, 152);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.MaxLength = 50;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 23);
            this.txtDiachi.TabIndex = 38;
            // 
            // lbDiachi
            // 
            this.lbDiachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(8, 160);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(52, 16);
            this.lbDiachi.TabIndex = 42;
            this.lbDiachi.Text = "Địa chỉ:";
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(400, 153);
            this.txtGT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(139, 23);
            this.txtGT.TabIndex = 39;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(400, 53);
            this.txtLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(139, 23);
            this.txtLop.TabIndex = 39;
            // 
            // txtMadg
            // 
            this.txtMadg.Location = new System.Drawing.Point(80, 53);
            this.txtMadg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMadg.MaxLength = 10;
            this.txtMadg.Name = "txtMadg";
            this.txtMadg.Size = new System.Drawing.Size(176, 23);
            this.txtMadg.TabIndex = 39;
            // 
            // txtTendg
            // 
            this.txtTendg.Location = new System.Drawing.Point(80, 88);
            this.txtTendg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTendg.Name = "txtTendg";
            this.txtTendg.Size = new System.Drawing.Size(176, 23);
            this.txtTendg.TabIndex = 39;
            // 
            // lbNgaytaothe
            // 
            this.lbNgaytaothe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgaytaothe.AutoSize = true;
            this.lbNgaytaothe.Location = new System.Drawing.Point(304, 96);
            this.lbNgaytaothe.Name = "lbNgaytaothe";
            this.lbNgaytaothe.Size = new System.Drawing.Size(85, 16);
            this.lbNgaytaothe.TabIndex = 43;
            this.lbNgaytaothe.Text = "Ngày tạo thẻ:";
            // 
            // lbMadg
            // 
            this.lbMadg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMadg.AutoSize = true;
            this.lbMadg.Location = new System.Drawing.Point(8, 56);
            this.lbMadg.Name = "lbMadg";
            this.lbMadg.Size = new System.Drawing.Size(51, 16);
            this.lbMadg.TabIndex = 45;
            this.lbMadg.Text = "Mã ĐG:";
            // 
            // lbNamsinh
            // 
            this.lbNamsinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNamsinh.AutoSize = true;
            this.lbNamsinh.Location = new System.Drawing.Point(304, 128);
            this.lbNamsinh.Name = "lbNamsinh";
            this.lbNamsinh.Size = new System.Drawing.Size(66, 16);
            this.lbNamsinh.TabIndex = 40;
            this.lbNamsinh.Text = "Năm sinh:";
            // 
            // lbTendg
            // 
            this.lbTendg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTendg.AutoSize = true;
            this.lbTendg.Location = new System.Drawing.Point(8, 96);
            this.lbTendg.Name = "lbTendg";
            this.lbTendg.Size = new System.Drawing.Size(56, 16);
            this.lbTendg.TabIndex = 47;
            this.lbTendg.Text = "Tên ĐG:";
            // 
            // lbLop
            // 
            this.lbLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(304, 64);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(33, 16);
            this.lbLop.TabIndex = 41;
            this.lbLop.Text = "Lớp:";
            // 
            // lbManv
            // 
            this.lbManv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbManv.AutoSize = true;
            this.lbManv.Location = new System.Drawing.Point(8, 128);
            this.lbManv.Name = "lbManv";
            this.lbManv.Size = new System.Drawing.Size(51, 16);
            this.lbManv.TabIndex = 46;
            this.lbManv.Text = "NV tạo:";
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(304, 160);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(59, 16);
            this.lbGioitinh.TabIndex = 44;
            this.lbGioitinh.Text = "Giới tính:";
            // 
            // dgDocgia
            // 
            this.dgDocgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocgia.Location = new System.Drawing.Point(6, 17);
            this.dgDocgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDocgia.Name = "dgDocgia";
            this.dgDocgia.RowHeadersWidth = 51;
            this.dgDocgia.Size = new System.Drawing.Size(543, 117);
            this.dgDocgia.TabIndex = 1;
            this.dgDocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDocgia_CellClick);
            // 
            // QLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLDocGia";
            this.Text = "frmDocgia";
            this.Load += new System.EventHandler(this.frmDocgia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocgia)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbDocgia;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txtTendg;
        private System.Windows.Forms.Label lbNgaytaothe;
        private System.Windows.Forms.Label lbMadg;
        private System.Windows.Forms.Label lbNamsinh;
        private System.Windows.Forms.Label lbTendg;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbManv;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Button btBC;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgDocgia;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMadg;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.DateTimePicker dtpNTT;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.Button btTV;
    }
}




