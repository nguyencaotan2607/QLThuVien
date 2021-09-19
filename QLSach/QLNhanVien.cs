using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLSach.BUS;

namespace QLSach
{
    public partial class QLNhanVien : Form
    {
        BUS_NhanVien busNhanvien;
        public QLNhanVien()
        {
            InitializeComponent();
            busNhanvien = new BUS_NhanVien();
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            HienthiDSNhanVien();
            busNhanvien.LayDSManv(cbTennv);
            busNhanvien.LayDSGioitinh(cbGioitinh);
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
                cbTennv.Text = dgNhanVien.Rows[e.RowIndex].Cells["Tennhanvien"].Value.ToString();
                txtSDT.Text = dgNhanVien.Rows[e.RowIndex].Cells["Sodienthoai"].Value.ToString();
                txtDiachi.Text = dgNhanVien.Rows[e.RowIndex].Cells["Điachi"].Value.ToString();
                dtNamSinh.Text = dgNhanVien.Rows[e.RowIndex].Cells["Namsinh"].Value.ToString();
                cbGioitinh.Text = dgNhanVien.Rows[e.RowIndex].Cells["Gioitinh"].Value.ToString();
                dtNgayLamViec.Text = dgNhanVien.Rows[e.RowIndex].Cells["NgayLamViec"].Value.ToString();
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
                DialogResult f = MessageBox.Show("Tiếp tục thoát ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (f == DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
            
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv = cbTennv.SelectedValue.ToString();
            n.Tennv = txtManv.Text;
            n.SDT = txtSDT.Text;
            n.Diachi = txtSDT.Text;
            n.Namsinh = dtNamSinh.Value;
            n.Gioitinh = cbGioitinh.SelectedValue.ToString();
            n.Ngaylamviec = dtNgayLamViec.Value;
            if (this.txtManv.TextLength == 0)
                MessageBox.Show("Tên nhân viên không được bỏ trống");
            else
                if (this.txtSDT.TextLength > 12)
                MessageBox.Show("số điện thoại không được vượt quá 12 ký tự");
            else
                if (this.txtDiachi.TextLength == 0)
                MessageBox.Show("địa chỉ không được bỏ trống");

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
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv= (txtManv.Text);
            n.Ngaylamviec = dtNgayLamViec.Value;
            n.Tennv = (cbTennv.SelectedValue.ToString());
            n.Gioitinh = cbGioitinh.SelectedValue.ToString();
            n.Namsinh = dtNamSinh.Value;
            n.Diachi = txtDiachi.Text;
            n.SDT = txtSDT.Text;

            if (busNhanvien.SuaNV(n))
            {
                MessageBox.Show("Sửa đơn hàng thành công");
                busNhanvien.HienThiDSNhanVien(dgNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Manv= txtManv.Text;

            if (busNhanvien.XoaNV(n))
            {
                MessageBox.Show("Xoá sản phẩm thành công");
                busNhanvien.HienThiDSNhanVien(dgNhanVien);
            }
            else
            {
                MessageBox.Show("Xoá sản phẩm thất bại");
            }
        }
    }
}
