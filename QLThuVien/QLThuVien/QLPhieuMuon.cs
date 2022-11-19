using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuVien.BUS;
using QLThuVien.Report;

namespace QLThuVien
{
    public partial class QLPhieuMuon : Form
    {
        BUS_PhieuMuon busPhieuMuon;
        public QLPhieuMuon()
        {
            InitializeComponent();
            busPhieuMuon = new BUS_PhieuMuon();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public void HienthiDSPhieuMuon()
        {
            dgPhieuMuon.DataSource = null;
            busPhieuMuon.HienThiDSPhieuMuon(dgPhieuMuon);
            dgPhieuMuon.Columns[0].Width = (int)(0.3 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[1].Width = (int)(0.3 * dgPhieuMuon.Width);
            dgPhieuMuon.Columns[2].Width = (int)(0.3 * dgPhieuMuon.Width);


        }

        private void QLPhieuMuon_Load(object sender, EventArgs e)
        {
            HienthiDSPhieuMuon();
            busPhieuMuon.LayDSNhanVien(cbNV);
        }

        private void dgPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPhieuMuon.Rows.Count)
            {
                txtMaPhieu.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Maphieu"].Value.ToString();
                cbNV.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Tennv"].Value.ToString();
                dtpNgayLapPhieu.Text = dgPhieuMuon.Rows[e.RowIndex].Cells["Ngaylapphieu"].Value.ToString();

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            Phieumuon p = new Phieumuon();
            p.Maphieu = txtMaPhieu.Text;
            p.Manv = cbNV.SelectedValue.ToString();
            p.Ngaylapphieu = dtpNgayLapPhieu.Value;

            if (busPhieuMuon.KTPM(p))
            {
                MessageBox.Show("Phiếu mượn đã tồn tại");
                return;
            }

            //Gọi BUS
            if (busPhieuMuon.TaoPhieu(p))
            {
                MessageBox.Show("Thêm Phiếu Mượn Thành Công");
                busPhieuMuon.HienThiDSPhieuMuon(dgPhieuMuon);
              

                FChiTietPhieuMuon CTPM = new FChiTietPhieuMuon(txtMaPhieu.Text);
                


                this.Close();
                CTPM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thêm Phiếu Mượn không Thành Công");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Phieumuon p = new Phieumuon();
            p.Maphieu = txtMaPhieu.Text;
            p.Manv = cbNV.SelectedValue.ToString();
            p.Ngaylapphieu = dtpNgayLapPhieu.Value;

            if (busPhieuMuon.SuaPhieu(p))
            {
                MessageBox.Show("Sửa Phiếu Mượn thành công");
                busPhieuMuon.HienThiDSPhieuMuon(dgPhieuMuon);
            }
            else
            {
                MessageBox.Show("Sửa Phiếu Mượn thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Phieumuon p = new Phieumuon();

            p.Maphieu = txtMaPhieu.Text;

            if (busPhieuMuon.XoaPhieu(p))
            {
                MessageBox.Show("Xoá Phiếu Mượn thành công");
                busPhieuMuon.HienThiDSPhieuMuon(dgPhieuMuon);
            }
            else
            {
                MessageBox.Show("Xoá Phiếu Mượn thất bại");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn trở về? ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                QuanLy l = new QuanLy();
                this.Close();
                l.Show();
            }
        }

        private void dgPhieuMuon_DoubleClick(object sender, EventArgs e)
        {
            string ma;
            ma = dgPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            //truyền cho form CTPM

            FChiTietPhieuMuon CTPM = new FChiTietPhieuMuon(txtMaPhieu.Text);
            CTPM.MaPhieu = ma;            
            CTPM.ShowDialog();
            this.Close();
           
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            RP_PhieuMuon r = new RP_PhieuMuon();
            RPPhieuMuon f = new RPPhieuMuon();

            r.SetDataSource(busPhieuMuon.HienThiDSPhieuMuonRP().ToList());

            f.CRPPhieuMuon.ReportSource = r;

            f.Show();
        }
    }
}
