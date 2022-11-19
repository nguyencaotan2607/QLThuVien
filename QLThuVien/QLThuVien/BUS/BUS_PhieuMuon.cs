using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using QLThuVien.DAO;

namespace QLThuVien.BUS
{
    class BUS_PhieuMuon
    {
        DAO_PhieuMuon dphieumuon;

        public BUS_PhieuMuon()
        {
            dphieumuon = new DAO_PhieuMuon();
        }

        public void HienThiDSPhieuMuon(DataGridView dg)
        {
            dg.DataSource = dphieumuon.LayDSPhieuMuon();
        }

        public void LayDSNhanVien(ComboBox cb)
        {
            cb.DataSource = dphieumuon.LayDSNV();
            cb.DisplayMember = "Tennv";
            cb.ValueMember = "Manv";
        }        

        public List<Phieumuon> HienThiDSPhieuMuonRP()
        {
            return dphieumuon.LayDSPhieuMuonRP();
        }

        public bool TaoPhieu(Phieumuon n)
        {           
                dphieumuon.ThemPhieu(n);
                return true;            
        }

        public bool KTPM(Phieumuon dg)
        {
            return dphieumuon.KiemTraPhieuMuon(dg);
        }
        public bool SuaPhieu(Phieumuon n)
        {
            if (dphieumuon.KiemTraPhieuMuon(n))
            {
                try
                {
                    dphieumuon.SuaPhieu(n);
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
        public bool XoaPhieu(Phieumuon n)
        {
            if (dphieumuon.KiemTraPhieuMuon(n))
                try
                {
                    dphieumuon.XoaPhieu(n);
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
