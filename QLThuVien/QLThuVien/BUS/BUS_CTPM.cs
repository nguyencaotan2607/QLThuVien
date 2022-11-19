using QLThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.BUS
{
    class BUS_CTPM
    {
        DAO_CTPM dCTPM;

        public BUS_CTPM()
        {
            dCTPM = new DAO_CTPM();
        }


        public void LayDSCTPhieuMuon(DataGridView dg, string maPhieu)
        {
            dg.DataSource = dCTPM.DSCTPM(maPhieu);
        }        

        public void LayDSDocGia(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSDG();
            cb.DisplayMember = "Tendg";
            cb.ValueMember = "Madg";
        }

        public void LayDSSach(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSS();
            cb.DisplayMember = "Tensach";
            cb.ValueMember = "Masach";
        }

        public void LayDSNhanVien(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSNV();
            cb.DisplayMember = "Tennv";
            cb.ValueMember = "Manv";
        }

       
        public bool TaoCTPhieuMuon(CTPM n)
        {
            try
            {
                dCTPM.ThemCTPM(n);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SuaCTPM(CTPM d, CTPM a)
        {            
                try
                {
                    dCTPM.SuaCTPM(d,a);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }           
        }

        public bool XoaCTPM(CTPM d)
        {            
                try
                {
                    dCTPM.XoaCTPM(d);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }            
        }
    }
}
