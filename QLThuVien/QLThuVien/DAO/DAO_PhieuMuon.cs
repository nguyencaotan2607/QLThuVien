using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLThuVien.DAO
{
    class DAO_PhieuMuon
    {
        QLThuVienEntities7 db;
        public DAO_PhieuMuon()
        {
            db = new QLThuVienEntities7();
        }

        public dynamic LayDSPhieuMuon()
        {
            var ds = db.Phieumuons.Select(s => new
            {
                s.Maphieu,
                s.Nhanvien.Tennv,
                s.Ngaylapphieu

            }).ToList();
            return ds;
        }

        public List<Phieumuon> LayDSPhieuMuonRP()
        {
            var ds = db.Phieumuons.Select(s => s).Where(s => s.Ngaylapphieu == DateTime.Today).ToList();
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

        public bool KiemTraPhieuMuon(Phieumuon n)
        {
            Phieumuon k = db.Phieumuons.Find(n.Maphieu);
            if (k != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ThemPhieu(Phieumuon n)
        {
            db.Phieumuons.Add(n);
            db.SaveChanges();
        }

        public void SuaPhieu(Phieumuon n)
        {
            Phieumuon k = db.Phieumuons.Find(n.Maphieu);
            k.Maphieu = n.Maphieu;
            k.Manv = n.Manv;
            k.Ngaylapphieu = n.Ngaylapphieu;

            db.SaveChanges();
        }

        public void XoaPhieu(Phieumuon n)
        {
            Phieumuon k = db.Phieumuons.Find(n.Maphieu);
            db.Phieumuons.Remove(k);
            db.SaveChanges();
        }             
    }
}

