using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLSach.DAO
{
    class DAO_CTPM
    {
        QLThuVienEntities db;

        public DAO_CTPM()
        {
            db = new QLThuVienEntities();
        }

        public dynamic LayDSKHDaMuonSach()
        {
            var ds = db.CTPMs.Select(s => new
            {
                s.Maphieu,
                s.Manv,
                s.Madg,
                s.Ngaylapphieu,
                s.Masach
            }).ToList();
            return ds;
        }

        public dynamic LayDSPhieu()
        {
            var ds = db.CTPMs.Select(s => new
            {
                s.Maphieu,
                s.Phieumuon
            }).ToList();
            return ds;
        }

        public dynamic LayDSNV()
        {
            var ds = db.Nhanviens.Select(s => new
            {
                s.Manv,
                s.Tennv
            }).ToList();
            return ds;
        }

        public dynamic LayDSDG()
        {
            var ds = db.Docgias.Select(s => new
            {
                s.Madg,
                s.Tendg
            }).ToList();
            return ds;
        }

        public dynamic LayDSSach()
        {
            var ds = db.Saches.Select(s => new
            {
                s.Masach,
                s.Tensach
            }).ToList();
            return ds;
        }

        public void ThemCTPM(CTPM c)
        {
            db.CTPMs.Add(c);
            db.SaveChanges();
        }

        public bool KiemTraCTPM(CTPM c)
        {
            CTPM p = db.CTPMs.Find(c.Maphieu);
            if (c != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaCTPM(CTPM c)
        {
            CTPM p = db.CTPMs.Find(c.Maphieu);
            p.Madg = c.Madg;
            p.Ngaylapphieu = c.Ngaylapphieu;
            p.Masach = c.Masach;
            db.SaveChanges();
        }

        public void XoaCTPM(CTPM c)
        {
            CTPM p = db.CTPMs.Find(c.Maphieu);
            db.CTPMs.Remove(p);
            db.SaveChanges();
        }
    }
}
