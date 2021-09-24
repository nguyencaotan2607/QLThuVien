using QLSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSach
{
    public partial class FCTPM : Form
    {
        BUS_CTPM busCTPM;
        public FCTPM()
        {
            InitializeComponent();
            busCTPM = new BUS_CTPM();
        }

        private void HienThiDSKHDaMuonSach()
        {
            dgCTPM.DataSource = null;
            busCTPM.LayDSKHDaMuonSach(dgCTPM);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            CTPM c = new CTPM();
            c.Maphieu = cbMaPM.Text;
            c.Manv = cbManv.SelectedValue.ToString();
            c.Madg = cbMadg.SelectedValue.ToString();
            c.Ngaylapphieu = dtpNgayLapPhieu.Value;
            c.Masach = cbMasach.SelectedValue.ToString();

            //Goi su kien SUA cua BUS

            if (busCTPM.SuaCTPM(c))
            {
                MessageBox.Show("Sửa phiếu mượn thành công");
                busCTPM.LayDSKHDaMuonSach(dgCTPM);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại!");
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbPhieumuon_Click(object sender, EventArgs e)
        {

        }

        private void FCTPM_Load(object sender, EventArgs e)
        {
            HienThiDSKHDaMuonSach();
            busCTPM.LayDSPhieu(cbMaPM);
            busCTPM.LayDSNV(cbManv);
            busCTPM.LayDSDG(cbMadg); 
            //busCTPM.LayDSNgayLapPhieu();
            busCTPM.LayDSSach(cbMasach);
            CapNhat();
        }

        private void lbManhanvien_Click(object sender, EventArgs e)
        {

        }

        private void cbMadg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.RowIndex<dgCTPM.Rows.Count)
            {
                cbMaPM.Text = dgCTPM.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbManv.Text = dgCTPM.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMadg.Text = dgCTPM.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayLapPhieu.Text = dgCTPM.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbMasach.Text = dgCTPM.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            CTPM chiTietPM = new CTPM();
            chiTietPM.Maphieu =cbMaPM.SelectedValue.ToString();
            chiTietPM.Manv = cbManv.SelectedValue.ToString();
            chiTietPM.Madg = cbMadg.SelectedValue.ToString();
            chiTietPM.Ngaylapphieu = dtpNgayLapPhieu.Value;
            chiTietPM.Masach = cbMasach.SelectedValue.ToString();

            if (busCTPM.TaoCTPM(chiTietPM))
            {
                MessageBox.Show("Tạo phiếu mượn thành công");
                busCTPM.LayDSKHDaMuonSach(dgCTPM);
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại!");
            }


        }


        void CapNhat()
        {
            busCTPM.LayDSKHDaMuonSach(dgCTPM);
            dgCTPM.Columns[0].Width = (int)(0.2 * dgCTPM.Width);
            dgCTPM.Columns[1].Width = (int)(0.2 * dgCTPM.Width);
            dgCTPM.Columns[2].Width = (int)(0.1 * dgCTPM.Width);
            dgCTPM.Columns[3].Width = (int)(0.25 * dgCTPM.Width);
            dgCTPM.Columns[4].Width = (int)(0.25 * dgCTPM.Width);
            

        }
        private void mkNgaylapphieu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            CTPM c = new CTPM();
            c.Maphieu = cbMaPM.Text;

            //Goi su kien xoa cua BUS

            if (busCTPM.XoaCTPM(c))
            {
                MessageBox.Show("Xóa phiếu mượn thành công");
                busCTPM.LayDSKHDaMuonSach(dgCTPM);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng thất bại!");
            }
        }
    }
}
