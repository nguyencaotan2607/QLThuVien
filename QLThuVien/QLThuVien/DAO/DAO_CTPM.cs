using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    class DAO_CTPM
    {

        QLThuVienEntities7 db;
        public DAO_CTPM()
        {
            db = new QLThuVienEntities7();
        }

        
        public dynamic DSCTPM(string maPhieu)
        {
            var ds = db.CTPMs.Where(s => s.Maphieu == maPhieu)
                .Select(s => new
                {
                    s.Maphieu,
                    s.Nhanvien.Tennv,
                    s.Docgia.Tendg,
                    s.Ngaylapphieu,
                    s.Sach.Tensach,

                }).ToList();
            return ds;
        }        

        public dynamic LayDSDG()
        {
            var ds = db.Docgias.Select(s => new
            {
                s.Madg,
                s.Tendg,
            }).ToList();
            return ds;
        }

        public dynamic LayDSS()
        {
            var ds = db.Saches.Select(s => new
            {
                s.Masach,
                s.Tensach,
            }).ToList();
            return ds;
        }

        public dynamic LayDSNV()
        {
            var ds = db.Nhanviens.Select(s => new
            {
                s.Manv,
                s.Tennv,
            }).ToList();
            return ds;
        }

        public void ThemCTPM(CTPM d)
        {
            db.CTPMs.Add(d);
            db.SaveChanges();
        }
       
        public bool SuaCTPM(CTPM n, CTPM z)
        {
            CTPM k = db.CTPMs.FirstOrDefault(s => s.Maphieu == z.Maphieu && s.Manv == z.Manv
                                                && s.Madg == z.Madg && s.Masach == z.Masach);

            if (k != null)
            {
                k.Maphieu = n.Maphieu;
                k.Manv = n.Manv;
                k.Madg = n.Madg;
                k.Masach = n.Masach;

                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }            
        }
        public void XoaCTPM(CTPM z)
        {
            CTPM k = db.CTPMs.FirstOrDefault(s => s.Maphieu == z.Maphieu && s.Manv == z.Manv
                                                && s.Madg == z.Madg && s.Masach == z.Masach);
            db.CTPMs.Remove(k);
            db.SaveChanges();
        }
    }
}
