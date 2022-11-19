using QLThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BUS
{
    class BUS_Login
    {
        DAO_Login dLogin;

        public BUS_Login()
        {
            dLogin = new DAO_Login();
        }

        public bool login(string tk, string mk)
        {
            return dLogin.login(tk, mk);
        }
    }
}
