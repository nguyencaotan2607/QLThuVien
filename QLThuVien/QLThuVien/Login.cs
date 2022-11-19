using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLThuVien.BUS;

namespace QLThuVien
{    

    public partial class Login : Form
    {

        BUS_Login bLogin;
        public Login()
        {
            bLogin = new BUS_Login();

            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void btDangNhap_Click_1(object sender, EventArgs e)
        {
            string tk = txttk.Text.Trim();
            string mk = txtmk.Text.Trim();

            if (bLogin.login(tk, mk))
            {                              
                QuanLy l = new QuanLy(tk);
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thoát hay không ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
