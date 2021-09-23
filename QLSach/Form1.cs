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
    public partial class Form1 : Form
    {
        BUS_QLSach busSach;
        public Form1()
        {
            InitializeComponent();
            busSach = new BUS_QLSach();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiDSSach();
            busSach.LayDSNXB(cbNXB);
            busSach.LayDSLoaiSach(cbLoaisach);
            busSach.LayDSLinhVuc(cbLinhvuc);
            CapNhat();
        }

        public void HienthiDSSach()
        {
            dgSach.DataSource = null;
            busSach.LayDSSach(dgSach);
        }

        void CapNhat()
        {
            busSach.LayDSSach(dgSach);
            dgSach.Columns[0].Width = (int)(0.08 * dgSach.Width);
            dgSach.Columns[1].Width = (int)(0.2 * dgSach.Width);
            dgSach.Columns[2].Width = (int)(0.14 * dgSach.Width);
            dgSach.Columns[3].Width = (int)(0.14 * dgSach.Width);
            dgSach.Columns[4].Width = (int)(0.14 * dgSach.Width);
            dgSach.Columns[5].Width = (int)(0.12 * dgSach.Width);
            dgSach.Columns[6].Width = (int)(0.14 * dgSach.Width);

        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgSach.Rows.Count)
            {
                txtmasach.Text = dgSach.Rows[e.RowIndex].Cells["Masach"].Value.ToString();
                txtTensach.Text = dgSach.Rows[e.RowIndex].Cells["Tensach"].Value.ToString();
                cbLoaisach.Text = dgSach.Rows[e.RowIndex].Cells["Loaisach"].Value.ToString();
                cbLinhvuc.Text = dgSach.Rows[e.RowIndex].Cells["Linhvuc"].Value.ToString();
                txtTacgia.Text = dgSach.Rows[e.RowIndex].Cells["Tacgia"].Value.ToString();
                cbNXB.Text = dgSach.Rows[e.RowIndex].Cells["NXB"].Value.ToString();
               dtpNXB.Text = dgSach.Rows[e.RowIndex].Cells["Ngayxuatban"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Sach n = new Sach();
            n.Masach = txtmasach.Text;
            n.Tensach = txtTensach.Text;
            n.Loaisach = cbLoaisach.SelectedValue.ToString();
            n.Linhvuc = cbLinhvuc.SelectedValue.ToString();
            n.Tacgia = txtTacgia.Text;
            n.NXB = cbNXB.SelectedValue.ToString();
            n.Ngayxuatban = dtpNXB.Value;
            //Gọi BUS
            if (busSach.TaoSach(n))
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công");
                busSach.HienThiDSSach(dgSach);
            }
            else
            {
                MessageBox.Show("Thêm Nhân Viên không Thành Công");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Sach n = new Sach();
            n.Masach = txtmasach.Text;
            n.Tensach = txtTensach.Text;
            n.Loaisach = cbLoaisach.SelectedValue.ToString();
            n.Linhvuc = cbLinhvuc.SelectedValue.ToString();
            n.Tacgia = txtTacgia.Text;
            n.NXB = cbNXB.SelectedValue.ToString();
            n.Ngayxuatban = dtpNXB.Value;

            if (busSach.SuaSach(n))
            {
                MessageBox.Show("Sửa Nhân Viên thành công");
                busSach.HienThiDSSach(dgSach);
            }
            else
            {
                MessageBox.Show("Sửa Nhân Viên thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Sach n = new Sach();
            n.Masach = txtmasach.Text;

            if (busSach.XoaSach(n))
            {
                MessageBox.Show("Xoá Nhân Viên thành công");
                busSach.HienThiDSSach(dgSach);
            }
            else
            {
                MessageBox.Show("Xoá Nhân Viên thất bại");
            }
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            HienthiDSSach();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn trở về? ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                QuanLy ql = new QuanLy();
                ql.ShowDialog();
            }
        }
    }
}
