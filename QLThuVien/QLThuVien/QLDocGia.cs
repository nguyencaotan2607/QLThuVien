using QLThuVien.BUS;
using QLThuVien.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLThuVien
{
    public partial class QLDocGia : Form
    {
        BUS.BUS_DocGia busDocGia;
        public QLDocGia()
        {
            InitializeComponent();
            busDocGia = new BUS_DocGia();

            dtpNamSinh.MaxDate = DateTime.Today;
            dtpNTT.MaxDate = DateTime.Today;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void HienThiDSDocGia()
        {
            dgDocgia.DataSource = null;
            busDocGia.HienThiDSDocGia(dgDocgia);
        }

        private void QLDocGia_Load(object sender, EventArgs e)
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

        private void btThem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Không có mã độc giả");
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

            if (busDocGia.SuaDG(d))
            {
                MessageBox.Show("Lưu thay đổi thành công");
                busDocGia.HienThiDSDocGia(dgDocgia);
            }
            else
            {
                MessageBox.Show("Độc giả không tồn tại");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMadg.Text.Trim() == "")
            {
                MessageBox.Show("Không có mã độc giả");
                return;
            }

            Docgia d = new Docgia();
            d.Madg = txtMadg.Text;

            if (busDocGia.XoaDG(d))
            {
                MessageBox.Show("Xóa độc giả thành công");
                busDocGia.HienThiDSDocGia(dgDocgia);
            }
            else
            {
                MessageBox.Show("Độc giả không tồn tại");
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

        private void btnTK_Click(object sender, EventArgs e)
        {
            RP_DocGia r = new RP_DocGia();
            RPDocGia f = new RPDocGia();

            r.SetDataSource(busDocGia.HienThiDSDocGiaRP().ToList());

            f.CRPDocGia.ReportSource = r;

            f.Show();

        }
    }
}
