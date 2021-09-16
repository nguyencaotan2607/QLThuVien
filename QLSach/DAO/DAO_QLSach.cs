using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QLSach.DAO
{
    class DAO_QLSach
    {
        QLThuVienEntities db;
        
        public DAO_QLSach()
        {
            db = new QLThuVienEntities();
            
        }

        public dynamic LayDSSach()
        {
            var ds = db.Saches.Select(s => new
                {
                    s.Masach,
                    s.Tensach,
                    s.Loaisach,
                    s.Linhvuc,
                    s.Tacgia,
                    s.NXB,
                    s.Ngayxuatban
                }).ToList();
            return ds;
        }

        public dynamic LayDSNXB()
        {
            var ds = db.Saches.Select(s => new
            {
                s.NXB
 
            }).ToList();
            return ds;
        }

        public dynamic LayDSLinhVuc()
        {
            var ds = db.Saches.Select(s => new
            {
                s.Linhvuc

            }).ToList();
            return ds;
        }

        public dynamic LayDSMaSach()
        {
            var ds = db.Saches.Select(s => new
            {
                s.Masach

            }).ToList();
            return ds;
        }

        public dynamic LayDSLoaiSach()
        {
            var ds = db.Saches.Select(s => new
            {
                s.Loaisach

            }).ToList();
            return ds;
        }


        public void ThemSach(Sach themSach)
        {
            db.Saches.Add(themSach);
            db.SaveChanges();
        }

    }
}
