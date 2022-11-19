using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    class DAO_DocGia
    {
        QLThuVienEntities7 db;

        public DAO_DocGia()
        {
            db = new QLThuVienEntities7();
        }

        public dynamic LayDSDocGia()
        {
            var ds = db.Docgias.Select(s => new
            {
                s.Madg,
                s.Tendg,
                s.Namsinh,
                s.Gioitinh,
                s.Diachi,
                s.Lop,
                s.Ngaytaothe,
                s.Nhanvien.Tennv,
            }).OrderByDescending(p => p.Ngaytaothe).ToList();
            return ds;
        }

        public List<Docgia> LayDSDocGiaRP()
        {
            var ds = db.Docgias.Select(s => s).Where(s => s.Ngaytaothe == DateTime.Today).ToList();
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

        public void ThemDG(Docgia d)
        {
            db.Docgias.Add(d);
            db.SaveChanges();
        }


        public bool KiemTraDG(Docgia d)
        {
            Docgia o = db.Docgias.Find(d.Madg);
            if (o != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SuaDG(Docgia d)
        {
            Docgia o = db.Docgias.Find(d.Madg);
            o.Madg = d.Madg;
            o.Tendg = d.Tendg;
            o.Manv = d.Manv;
            o.Diachi = d.Diachi;
            o.Lop = d.Lop;
            o.Ngaytaothe = d.Ngaytaothe;
            o.Namsinh = d.Namsinh;
            o.Gioitinh = d.Gioitinh;
            db.SaveChanges();
        }

        public void XoaDG(Docgia d)
        {
            Docgia o = db.Docgias.Find(d.Madg);
            db.Docgias.Remove(o);
            db.SaveChanges();
        }
    }
}
