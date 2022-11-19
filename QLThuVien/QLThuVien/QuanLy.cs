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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        public QuanLy(string tk)
        {                             
            InitializeComponent();

            QLThuVienEntities7 t = new QLThuVienEntities7();

            var loai = t.Taikhoans.FirstOrDefault(s => tk == s.Tk && s.loai == "nhanvien");

            if (loai != null)
            {
                btQLnhanvien.Enabled = false;
            }
        }
        private void btQLsach_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btQLnhanvien_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            f.Show();
            this.Hide();
        }

        private void btQLdocgia_Click(object sender, EventArgs e)
        {
            QLDocGia f = new QLDocGia();
            f.Show();
            this.Hide();
        }

        private void btQLphieumuon_Click(object sender, EventArgs e)
        {
            QLPhieuMuon f = new QLPhieuMuon();
            f.Show();
            this.Hide();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn đăng xuất không?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                Login l = new Login();
                this.Close();
                l.Show();
            }
        }
    }
}
