using QLSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSach.Report;

namespace QLSach
{
    public partial class QLDocGia : Form
    {
        BUS.BUSDocGia busDocGia;
        public QLDocGia()
        {
            InitializeComponent();
            busDocGia = new BUSDocGia();
        }

        private void HienThiDSDocGia()
        {
            dgDocgia.DataSource = null;
            busDocGia.HienThiDSDocGia(dgDocgia);
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            HienThiDSDocGia();
            busDocGia.LayDSNhanVien(cbNV);
        }

        private void dgDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgDocgia.Rows.Count)
            {
                txtMadg.Text = dgDocgia.Rows[e.RowIndex].Cells["Madg"].Value.ToString();
                txtTendg.Text = dgDocgia.Rows[e.RowIndex].Cells["Tendg"].Value.ToString();
                dtpNamSinh.Text = dgDocgia.Rows[e.RowIndex].Cells["Namsinh"].Value.ToString();
                txtGT.Text = dgDocgia.Rows[e.RowIndex].Cells["Gioitinh"].Value.ToString();
                txtDiachi.Text = dgDocgia.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                txtLop.Text = dgDocgia.Rows[e.RowIndex].Cells["Lop"].Value.ToString();
                dtpNTT.Text = dgDocgia.Rows[e.RowIndex].Cells["Ngaytaothe"].Value.ToString();
                cbNV.Text = dgDocgia.Rows[e.RowIndex].Cells["Tennv"].Value.ToString();
            }
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (txtMadg.Text.Trim() == "")
            {
                MessageBox.Show("Không có mã độc giả");
                return;
            }            

            Docgia DocGia = new Docgia();
            DocGia.Madg = txtMadg.Text;
            DocGia.Tendg = txtTendg.Text;
            DocGia.Manv = cbNV.SelectedValue.ToString();
            DocGia.Diachi = txtDiachi.Text;
            DocGia.Lop = txtLop.Text;
            DocGia.Ngaytaothe = dtpNTT.Value;
            DocGia.Namsinh = dtpNamSinh.Value;
            DocGia.Gioitinh = txtGT.Text;

            if (busDocGia.KTMadg(DocGia))
            {
                MessageBox.Show("Độc giả đã tồn tại");
                return;
            }

            if (busDocGia.TaoDG(DocGia))
            {
                MessageBox.Show("Thêm độc giả thành công");
                busDocGia.HienThiDSDocGia(dgDocgia);
            }
            else
            {
                MessageBox.Show("Thêm độc giả thất bại");
            }

            txtMadg.Clear();
            txtTendg.Clear();
            txtDiachi.Clear();
            txtLop.Clear();
            txtGT.Clear();
            busDocGia.LayDSNhanVien(cbNV);
            dtpNamSinh.ResetText();
            dtpNTT.ResetText();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text.Trim() == "")
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }

            Docgia d = new Docgia();
            d.Madg = txtMadg.Text;
            d.Tendg = txtTendg.Text;
            d.Manv = cbNV.SelectedValue.ToString();
            d.Diachi = txtDiachi.Text;
            d.Lop = txtLop.Text;
            d.Ngaytaothe = dtpNTT.Value;
            d.Namsinh = dtpNamSinh.Value;
            d.Gioitinh = txtGT.Text;

            if (!busDocGia.KTMadg(d))
            {
                MessageBox.Show("Không thay đổi mã độc giả");
                return;
            }

            if (busDocGia.SuaDH(d))
            {
                MessageBox.Show("Lưu thay đổi thành công");
                busDocGia.HienThiDSDocGia(dgDocgia);
            }
            else
            {
                MessageBox.Show("Lưu thay đổi thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text.Trim() == "")
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }

            Docgia d = new Docgia();
            d.Madg = txtMadg.Text;

            if (busDocGia.XoaDH(d))
            {
                MessageBox.Show("Xóa độc giả thành công");
                busDocGia.HienThiDSDocGia(dgDocgia);
            }
            else
            {
                MessageBox.Show("Xóa độc giả thất bại");
            }

            txtMadg.Clear();
            txtTendg.Clear();
            txtDiachi.Clear();
            txtLop.Clear();
            txtGT.Clear();
            busDocGia.LayDSNhanVien(cbNV);
            dtpNamSinh.ResetText();
            dtpNTT.ResetText();

        }
        private void btBC_Click(object sender, EventArgs e)
        {
            RPDocGia r = new RPDocGia();
            RPDocGia f = new RPDocGia();

            r.SetDataSource(busDocGia.HienThiDSDocGiaRP().ToList());
            f.crystalReportViewer1.ReportSource = r;

            f.Show();
        }

        private void btTV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
