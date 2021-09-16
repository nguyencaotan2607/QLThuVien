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
            busSach.LayDSMaSach(cbMasach);
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
                cbMasach.Text = dgSach.Rows[e.RowIndex].Cells["Masach"].Value.ToString();
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
            Sach QLSach = new Sach();
            QLSach.Masach = cbMasach.SelectedValue.ToString();
            QLSach.Tensach = txtTensach.Text;
            QLSach.Loaisach = cbMasach.SelectedValue.ToString();
            QLSach.Linhvuc = cbLinhvuc.SelectedValue.ToString();
            QLSach.Tacgia = txtTacgia.Text;
            QLSach.NXB = cbNXB.SelectedValue.ToString();
            QLSach.Ngayxuatban = dtpNXB.Value;

            //Gọi BUS
            if(busSach.ThemSach(QLSach))
            {
                MessageBox.Show("Thêm Sách Thành Công");
                busSach.LayDSSach(dgSach);
            }else
            {
                MessageBox.Show("Thêm Sách không Thành Công");
            }
        }
      


    }
}
