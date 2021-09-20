using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLSach.DAO
{
    class DAO_NhanVien
    {
        QLThuVienEntities1 db;
        public DAO_NhanVien()
        {
            db = new QLThuVienEntities1();
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
        public dynamic LayDSGioitinh()
        {
            var ds = db.Nhanviens.Select(s => new
            {
                s.Gioitinh

            }).ToList();
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
            if (n!=null)
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
