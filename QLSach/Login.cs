using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thoát hay không ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=QUANG;Initial Catalog=Admin;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                string sql = "select * from NguoiDung where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn); // lớp xác định các thao tác cần xử lý với csdl thông qua câu lệnh sql
                // lớp lấy dữ liệu về từ kết quả của câu lệnh phục vụ cho thao tác đọc dữ liệu 1 cách tuần tự
                SqlDataReader data = cmd.ExecuteReader(); // sử dụng cho câu lệnh select
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLy QL = new QuanLy();
                    QL.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }
    }
}
