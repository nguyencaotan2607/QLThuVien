using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuVien.BUS;

namespace QLThuVien
{
    public partial class FChiTietPhieuMuon : Form
    {
        public string MaPhieu;
        BUS_CTPM busCTPM;
        public FChiTietPhieuMuon()
        {
            InitializeComponent();
            busCTPM = new BUS_CTPM();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        public FChiTietPhieuMuon(string m)
        {
            InitializeComponent();
            busCTPM = new BUS_CTPM();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtMaPhieu.Text = m;
            txtMaPhieu.Enabled = false;
        }

        private void LayDSCTPM(string ma)
        {
            dgPhieuMuon.DataSource = null;
            busCTPM.LayDSCTPhieuMuon(dgPhieuMuon, ma);


            CapNhat();
        }

        private void FChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            LayDSCTPM(MaPhieu);

            busCTPM.LayDSDocGia(cbDG);
            busCTPM.LayDSSach(cbSach);
            busCTPM.LayDSNhanVien(cbNV);
           
        }


        void CapNhat()
        {

            dgPhieuMuon.Columns[0].Width = (int)(0.18 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[1].Width = (int)(0.2 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[2].Width = (int)(0.18 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[3].Width = (int)(0.18 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[4].Width = (int)(0.18 * dgPhieuMuon.Width);


        }
      

        private void dgPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPhieuMuon.Rows.Count)
            {       
                
                txtMaPhieu.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Maphieu"].Value.ToString();
                cbNV.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Tennv"].Value.ToString();
                cbDG.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Tendg"].Value.ToString();
                cbSach.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Tensach"].Value.ToString();
                dtpNgayLapPhieu.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Ngaylapphieu"].Value.ToString();                                    
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {          

            CTPM n = new CTPM();
            n.Maphieu = txtMaPhieu.Text;
            n.Manv = cbNV.SelectedValue.ToString();
            n.Madg = cbDG.SelectedValue.ToString();
            n.Masach = cbSach.SelectedValue.ToString();
            n.Ngaylapphieu = dtpNgayLapPhieu.Value;

            //Gọi BUS


            if (busCTPM.TaoCTPhieuMuon(n))
            {
                MessageBox.Show("Thêm Phiếu Thành Công");
                busCTPM.LayDSCTPhieuMuon(dgPhieuMuon,MaPhieu);               
            }
            else
            {
                MessageBox.Show("Thêm Phiếu Không Thành Công");
            }

            LayDSCTPM(txtMaPhieu.Text);
        }
               
        private void btSua_Click_1(object sender, EventArgs e)
        {           
            //CTPM d = new CTPM();

            //d.Maphieu = txtMaPhieu.Text;
            //d.Madg = cbDG.SelectedValue.ToString();
            //d.Manv = cbNV.SelectedValue.ToString();
            //d.Masach = cbSach.SelectedValue.ToString();


            //if (busCTPM.SuaCTPM(d,a))
            //{
            //    MessageBox.Show("Lưu thay đổi thành công");
            //    busCTPM.LayDSCTPhieuMuon(dgPhieuMuon, MaPhieu);
            //}
            //else
            //{
            //    MessageBox.Show("Lưu thay đổi thất bại");
            //}
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {           

            CTPM d = new CTPM();

            d.Maphieu = txtMaPhieu.Text;
            d.Madg = cbDG.SelectedValue.ToString();
            d.Manv = cbNV.SelectedValue.ToString();
            d.Masach = cbSach.SelectedValue.ToString();

            if (busCTPM.XoaCTPM(d))
            {
                MessageBox.Show("Xóa phiếu mượn thành công");
                busCTPM.LayDSCTPhieuMuon(dgPhieuMuon, MaPhieu);
            }
            else
            {
                MessageBox.Show("Xóa phiếu mượn thất bại");
            }

            txtMaPhieu.Clear();
            busCTPM.LayDSDocGia(cbDG);
            busCTPM.LayDSSach(cbSach);
            busCTPM.LayDSNhanVien(cbNV);
            dtpNgayLapPhieu.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn trở về? ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                QLPhieuMuon p = new QLPhieuMuon();
                this.Close();
                p.Show();
            }
        }
    }
}
