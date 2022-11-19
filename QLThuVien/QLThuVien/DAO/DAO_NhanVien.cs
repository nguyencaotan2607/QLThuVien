using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLThuVien.DAO
{
    class DAO_NhanVien
    {
        QLThuVienEntities7 db;
        public DAO_NhanVien()
        {
            db = new QLThuVienEntities7();
        }
        public dynamic LayDSNhanVien()
        {
            var ds = db.Nhanviens.Select(s => new
            {
                s.Manv,
                s.Tennv,
                s.SDT,
                s.Diachi,
                s.Namsinh,
                s.Gioitinh,
                s.Ngaylamviec
            }).ToList();
            return ds;
        }
        public dynamic LayDSDiachi()
        {
            var ds = db.Nhanviens.Select(s => new
            {
                s.Diachi

            }).ToList();
            return ds;
        }

        public List<Nhanvien> LayDSNhanVienRP()
        {
            var ds = db.Nhanviens.Select(s => s).ToList();
            return ds;
        }
        public void ThemNV(Nhanvien n)
        {
            db.Nhanviens.Add(n);
            db.SaveChanges();
        }
        public bool KiemTraNV(Nhanvien n)
        {
            Nhanvien k = db.Nhanviens.Find(n.Manv);
            if (k != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void SuaNV(Nhanvien n)
        {
            Nhanvien k = db.Nhanviens.Find(n.Manv);
            k.Manv = n.Manv;
            k.Tennv = n.Tennv;
            k.SDT = n.SDT;
            k.Diachi = n.Diachi;
            k.Namsinh = n.Namsinh;
            k.Gioitinh = n.Gioitinh;
            k.Ngaylamviec = n.Ngaylamviec;
            db.SaveChanges();
        }
        public void XoaNV(Nhanvien n)
        {
            Nhanvien k = db.Nhanviens.Find(n.Manv);
            db.Nhanviens.Remove(k);
            db.SaveChanges();
        }
    }
}
