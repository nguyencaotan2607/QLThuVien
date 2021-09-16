using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSach.DAO;
using System.Windows.Forms;

namespace QLSach.BUS
{
    class BUS_QLSach
    {
        DAO_QLSach dSach;
        public BUS_QLSach()
        {
            dSach = new DAO_QLSach();
        
        }

        public void LayDSSach(DataGridView dg)
        {
            dg.DataSource = dSach.LayDSSach();
        }

        public void LayDSNXB(ComboBox cb)
        {
            cb.DataSource = dSach.LayDSNXB();
            cb.DisplayMember = "NXB";
            cb.ValueMember = "NXB";
        }

        public void LayDSLinhVuc(ComboBox cb)
        {
            cb.DataSource = dSach.LayDSLinhVuc();
            cb.DisplayMember = "Linhvuc";
            cb.ValueMember = "Linhvuc";
        }

        public void LayDSMaSach(ComboBox cb)
        {
            cb.DataSource = dSach.LayDSMaSach();
            cb.DisplayMember = "Masach";
            cb.ValueMember = "Masach";
        }

        public void LayDSLoaiSach(ComboBox cb)
        {
            cb.DataSource = dSach.LayDSLoaiSach();
            cb.DisplayMember = "Loaisach";
            cb.ValueMember = "Loaisach";
        }


        public bool ThemSach(Sach S)
        {

            try
            {
                dSach.ThemSach(S);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
