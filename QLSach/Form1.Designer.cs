namespace QLSach
{
    partial class Form1
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
            this.lbSach = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.lbMasach = new System.Windows.Forms.Label();
            this.lbTensach = new System.Windows.Forms.Label();
            this.lbTacgia = new System.Windows.Forms.Label();
            this.lbLoaisach = new System.Windows.Forms.Label();
            this.lbNgayxuatban = new System.Windows.Forms.Label();
            this.lbLinhvuc = new System.Windows.Forms.Label();
            this.cbLoaisach = new System.Windows.Forms.ComboBox();
            this.cbLinhvuc = new System.Windows.Forms.ComboBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.lbMsach = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbLVuc = new System.Windows.Forms.Label();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.dtpNXB = new System.Windows.Forms.DateTimePicker();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.btnTrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSach
            // 
            this.lbSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSach.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbSach.Location = new System.Drawing.Point(0, 0);
            this.lbSach.Name = "lbSach";
            this.lbSach.Size = new System.Drawing.Size(971, 38);
            this.lbSach.TabIndex = 36;
            this.lbSach.Text = "QUẢN LÝ SÁCH";
            this.lbSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Location = new System.Drawing.Point(289, 220);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(97, 54);
            this.btThem.TabIndex = 49;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Location = new System.Drawing.Point(466, 220);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(108, 54);
            this.btSua.TabIndex = 47;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Location = new System.Drawing.Point(648, 220);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 54);
            this.btXoa.TabIndex = 46;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btMoi
            // 
            this.btMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMoi.Location = new System.Drawing.Point(96, 220);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(109, 54);
            this.btMoi.TabIndex = 48;
            this.btMoi.Text = "Làm Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // txtTensach
            // 
            this.txtTensach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTensach.Location = new System.Drawing.Point(96, 79);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(210, 27);
            this.txtTensach.TabIndex = 38;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacgia.Location = new System.Drawing.Point(497, 53);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(471, 27);
            this.txtTacgia.TabIndex = 37;
            // 
            // lbMasach
            // 
            this.lbMasach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMasach.AutoSize = true;
            this.lbMasach.Location = new System.Drawing.Point(0, 0);
            this.lbMasach.Name = "lbMasach";
            this.lbMasach.Size = new System.Drawing.Size(77, 21);
            this.lbMasach.TabIndex = 44;
            this.lbMasach.Text = "Mã sách:";
            // 
            // lbTensach
            // 
            this.lbTensach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTensach.AutoSize = true;
            this.lbTensach.Location = new System.Drawing.Point(0, 0);
            this.lbTensach.Name = "lbTensach";
            this.lbTensach.Size = new System.Drawing.Size(83, 21);
            this.lbTensach.TabIndex = 45;
            this.lbTensach.Text = "Tên sách:";
            // 
            // lbTacgia
            // 
            this.lbTacgia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTacgia.AutoSize = true;
            this.lbTacgia.Location = new System.Drawing.Point(405, 59);
            this.lbTacgia.Name = "lbTacgia";
            this.lbTacgia.Size = new System.Drawing.Size(70, 21);
            this.lbTacgia.TabIndex = 42;
            this.lbTacgia.Text = "Tác giả:";
            // 
            // lbLoaisach
            // 
            this.lbLoaisach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoaisach.AutoSize = true;
            this.lbLoaisach.Location = new System.Drawing.Point(0, 0);
            this.lbLoaisach.Name = "lbLoaisach";
            this.lbLoaisach.Size = new System.Drawing.Size(85, 21);
            this.lbLoaisach.TabIndex = 39;
            this.lbLoaisach.Text = "Loại sách:";
            // 
            // lbNgayxuatban
            // 
            this.lbNgayxuatban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgayxuatban.AutoSize = true;
            this.lbNgayxuatban.Location = new System.Drawing.Point(353, 112);
            this.lbNgayxuatban.Name = "lbNgayxuatban";
            this.lbNgayxuatban.Size = new System.Drawing.Size(122, 21);
            this.lbNgayxuatban.TabIndex = 41;
            this.lbNgayxuatban.Text = "Ngày xuất bản:";
            // 
            // lbLinhvuc
            // 
            this.lbLinhvuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLinhvuc.AutoSize = true;
            this.lbLinhvuc.Location = new System.Drawing.Point(0, 0);
            this.lbLinhvuc.Name = "lbLinhvuc";
            this.lbLinhvuc.Size = new System.Drawing.Size(77, 21);
            this.lbLinhvuc.TabIndex = 40;
            this.lbLinhvuc.Text = "Lĩnh vực:";
            // 
            // cbLoaisach
            // 
            this.cbLoaisach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaisach.FormattingEnabled = true;
            this.cbLoaisach.Location = new System.Drawing.Point(96, 113);
            this.cbLoaisach.Name = "cbLoaisach";
            this.cbLoaisach.Size = new System.Drawing.Size(210, 27);
            this.cbLoaisach.TabIndex = 51;
            // 
            // cbLinhvuc
            // 
            this.cbLinhvuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLinhvuc.FormattingEnabled = true;
            this.cbLinhvuc.Location = new System.Drawing.Point(96, 145);
            this.cbLinhvuc.Name = "cbLinhvuc";
            this.cbLinhvuc.Size = new System.Drawing.Size(517, 27);
            this.cbLinhvuc.TabIndex = 52;
            // 
            // lbNXB
            // 
            this.lbNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(428, 83);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(47, 21);
            this.lbNXB.TabIndex = 43;
            this.lbNXB.Text = "NXB:";
            // 
            // cbNXB
            // 
            this.cbNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(497, 81);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(471, 27);
            this.cbNXB.TabIndex = 50;
            // 
            // lbMsach
            // 
            this.lbMsach.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lbMsach.AutoSize = true;
            this.lbMsach.Location = new System.Drawing.Point(7, 51);
            this.lbMsach.Name = "lbMsach";
            this.lbMsach.Size = new System.Drawing.Size(78, 21);
            this.lbMsach.TabIndex = 55;
            this.lbMsach.Text = "Mã Sách:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(4, 83);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(84, 21);
            this.lbTen.TabIndex = 56;
            this.lbTen.Text = "Tên Sách:";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(5, 115);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(86, 21);
            this.lbLoai.TabIndex = 57;
            this.lbLoai.Text = "Loại Sách:";
            // 
            // lbLVuc
            // 
            this.lbLVuc.AutoSize = true;
            this.lbLVuc.Location = new System.Drawing.Point(7, 148);
            this.lbLVuc.Name = "lbLVuc";
            this.lbLVuc.Size = new System.Drawing.Size(79, 21);
            this.lbLVuc.TabIndex = 58;
            this.lbLVuc.Text = "Lĩnh Vực:";
            // 
            // dgSach
            // 
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Location = new System.Drawing.Point(4, 319);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 51;
            this.dgSach.RowTemplate.Height = 24;
            this.dgSach.Size = new System.Drawing.Size(964, 208);
            this.dgSach.TabIndex = 59;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // dtpNXB
            // 
            this.dtpNXB.Location = new System.Drawing.Point(497, 106);
            this.dtpNXB.Name = "dtpNXB";
            this.dtpNXB.Size = new System.Drawing.Size(471, 27);
            this.dtpNXB.TabIndex = 60;
            // 
            // txtmasach
            // 
            this.txtmasach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmasach.Location = new System.Drawing.Point(96, 41);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(210, 27);
            this.txtmasach.TabIndex = 61;
            // 
            // btnTrove
            // 
            this.btnTrove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrove.Location = new System.Drawing.Point(817, 220);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(98, 54);
            this.btnTrove.TabIndex = 62;
            this.btnTrove.Text = "Trở Về";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 539);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.dtpNXB);
            this.Controls.Add(this.dgSach);
            this.Controls.Add(this.lbLVuc);
            this.Controls.Add(this.lbLoai);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMsach);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.lbSach);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btMoi);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.txtTacgia);
            this.Controls.Add(this.lbMasach);
            this.Controls.Add(this.lbTensach);
            this.Controls.Add(this.lbTacgia);
            this.Controls.Add(this.lbLoaisach);
            this.Controls.Add(this.lbNgayxuatban);
            this.Controls.Add(this.lbLinhvuc);
            this.Controls.Add(this.cbLoaisach);
            this.Controls.Add(this.cbLinhvuc);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.cbNXB);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "QLSach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSach;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.Label lbMasach;
        private System.Windows.Forms.Label lbTensach;
        private System.Windows.Forms.Label lbTacgia;
        private System.Windows.Forms.Label lbLoaisach;
        private System.Windows.Forms.Label lbNgayxuatban;
        private System.Windows.Forms.Label lbLinhvuc;
        private System.Windows.Forms.ComboBox cbLoaisach;
        private System.Windows.Forms.ComboBox cbLinhvuc;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.Label lbMsach;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbLVuc;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.DateTimePicker dtpNXB;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Button btnTrove;
    }
}
