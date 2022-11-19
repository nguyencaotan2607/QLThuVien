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
    public partial class QLNhanVien : Form
    {
        BUS_NhanVien busNhanvien;
        public QLNhanVien()
        {
            InitializeComponent();
            busNhanvien = new BUS_NhanVien();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public void HienthiDSNhanVien()
        {
            dgNhanVien.DataSource = null;
            busNhanvien.HienThiDSNhanVien(dgNhanVien);
            dgNhanVien.Columns[0].Width = (int)(0.08 * dgNhanVien.Width);
            dgNhanVien.Columns[1].Width = (int)(0.2 * dgNhanVien.Width);
            dgNhanVien.Columns[2].Width = (int)(0.14 * dgNhanVien.Width);
            dgNhanVien.Columns[3].Width = (int)(0.14 * dgNhanVien.Width);
            dgNhanVien.Columns[4].Width = (int)(0.14 * dgNhanVien.Width);
            dgNhanVien.Columns[5].Width = (int)(0.12 * dgNhanVien.Width);
            dgNhanVien.Columns[6].Width = (int)(0.14 * dgNhanVien.Width);

        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgNhanVien.Rows.Count)
            {
                txtManv.Text = dgNhanVien.Rows[e.RowIndex].Cells["Manv"].Value.ToString();
                txtTennv.Text = dgNhanVien.Rows[e.RowIndex].Cells["Tennv"].Value.ToString();
                txtSDT.Text = dgNhanVien.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                cbDiachi.Text = dgNhanVien.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                dtNamSinh.Text = dgNhanVien.Rows[e.RowIndex].Cells["Namsinh"].Value.ToString();
                txtGioitinh.Text = dgNhanVien.Rows[e.RowIndex].Cells["Gioitinh"].Value.ToString();
                dtNgayLamViec.Text = dgNhanVien.Rows[e.RowIndex].Cells["Ngaylamviec"].Value.ToString();
            }
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            HienthiDSNhanVien();
            busNhanvien.LayDSDiachi(cbDiachi);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv = txtManv.Text;
            n.Tennv = txtTennv.Text;
            n.SDT = txtSDT.Text;
            n.Diachi = cbDiachi.SelectedValue.ToString(); ;
            n.Namsinh = dtNamSinh.Value;
            n.Gioitinh = txtGioitinh.Text;
            n.Ngaylamviec = dtNgayLamViec.Value;
            n.Tk = "nhanvien1";
            //Gọi BUS
            if (busNhanvien.TaoNV(n))
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công");
                busNhanvien.HienThiDSNhanVien(dgNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm Nhân Viên không Thành Công");
            }
            txtManv.Clear();
            txtTennv.Clear();
            txtSDT.Clear();
            txtGioitinh.Clear();
            busNhanvien.LayDSDiachi(cbDiachi);
            dtNamSinh.ResetText();
            dtNgayLamViec.ResetText();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv = txtManv.Text;
            n.Tennv = txtTennv.Text;
            n.SDT = txtSDT.Text;
            n.Diachi = cbDiachi.SelectedValue.ToString();
            n.Namsinh = dtNamSinh.Value;
            n.Gioitinh = txtGioitinh.Text;
            n.Ngaylamviec = dtNgayLamViec.Value;

            if (busNhanvien.SuaNV(n))
            {
                MessageBox.Show("Sửa Nhân Viên thành công");
                busNhanvien.HienThiDSNhanVien(dgNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa Nhân Viên thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv = txtManv.Text;

            if (busNhanvien.XoaNV(n))
            {
                MessageBox.Show("Xoá Nhân Viên thành công");
                busNhanvien.HienThiDSNhanVien(dgNhanVien);
            }
            else
            {
                MessageBox.Show("Xoá Nhân Viên thất bại");
            }
            txtManv.Clear();
            txtTennv.Clear();
            txtSDT.Clear();
            txtGioitinh.Clear();
            busNhanvien.LayDSDiachi(cbDiachi);
            dtNamSinh.ResetText();
            dtNgayLamViec.ResetText();
        }


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát? ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                QuanLy l = new QuanLy();
                this.Close();
                l.Show();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            RP_NhanVien r = new RP_NhanVien();
            RPNhanVien f = new RPNhanVien();

            r.SetDataSource(busNhanvien.HienThiDSNhanVienRP().ToList());

            f.CRPNhanVien.ReportSource = r;

            f.Show();
        }
    }
}
