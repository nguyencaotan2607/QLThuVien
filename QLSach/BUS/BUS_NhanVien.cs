using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSach.DAO;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace QLSach.BUS
{
    class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;
        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();

        }
        public void HienThiDSNhanVien(DataGridView dg)
        {
            dg.DataSource = dNhanVien.LayDSNhanVien();
        }
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = dNhanVien.LayDSNhanVien();

        }
        public void LayDSDiachi(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSDiachi();
            cb.DisplayMember = "Diachi";
            cb.ValueMember = "Diachi";
        }
        public void LayDSGioitinh(ComboBox cb)
        {
            cb.DataSource = dNhanVien.LayDSGioitinh();
            cb.DisplayMember = "Gioitinh";
            cb.ValueMember = "Gioitinh";
        }
        public bool TaoNV(Nhanvien n)
        {
            try
            {
                dNhanVien.ThemNV(n);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaNV(Nhanvien n)
        {
            if (dNhanVien.KiemTraNV(n))
            {
                try
                {
                    dNhanVien.SuaNV(n);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }    

        }
        public bool XoaNV(Nhanvien n)
        {
            if(dNhanVien.KiemTraNV(n))
                try
                {
                    dNhanVien.XoaNV(n);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            else
            {
                return false;
            }    
        }
    }
}
