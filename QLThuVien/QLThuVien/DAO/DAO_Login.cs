using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    class DAO_Login
    {

        QLThuVienEntities7 db;
        public DAO_Login()
        {
            db = new QLThuVienEntities7();
        }
        public bool login(string tk, string mk)
        {
            var data = db.Taikhoans.FirstOrDefault(s => tk == s.Tk && s.Mk == mk);

            if (data != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

