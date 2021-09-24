using QLSach.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSach.BUS
{
    class BUS_CTPM
    {
        DAO_CTPM dCTPM;
        public BUS_CTPM()
        {
            dCTPM = new DAO_CTPM();
        }

        public void LayDSKHDaMuonSach(DataGridView dg)
        {
            dg.DataSource = dCTPM.LayDSKHDaMuonSach();
        }

        public void LayDSPhieu(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSPhieu();
            cb.DisplayMember = "Phieumuon";
            cb.ValueMember = "Maphieu";
        }

        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSNV();
            cb.DisplayMember = "Tennv";
            cb.ValueMember = "Manv";
        }

        public void LayDSDG(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSDG();
            cb.DisplayMember = "Tendg";
            cb.ValueMember = "Madg";
        }

        public void LayDSSach(ComboBox cb)
        {
            cb.DataSource = dCTPM.LayDSSach();
            cb.DisplayMember = "Tensach";
            cb.ValueMember = "Masach";
        }

        public void LayDSNgayLapPhieu(StringBuilder db)
        {
            //db.ToString() = dCTPM.LayDSNgayLapPhieu();
        }

        public bool TaoCTPM(CTPM c)
        {
            try
            {
                dCTPM.ThemCTPM(c);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool SuaCTPM(CTPM c)
        {
            if (dCTPM.KiemTraCTPM(c))
            {
                //Sua
                try
                {
                    dCTPM.SuaCTPM(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
            else
                return false;

        }

        public bool XoaCTPM(CTPM c)
        {
            if (dCTPM.KiemTraCTPM(c))
            {
                try
                {
                    dCTPM.XoaCTPM(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
    }
}
