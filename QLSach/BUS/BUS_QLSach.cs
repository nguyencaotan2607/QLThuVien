using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSach.DAO;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace QLSach.BUS
{
    class BUS_QLSach
    {
        DAO_QLSach dSach;
        public BUS_QLSach()
        {
            dSach = new DAO_QLSach();
        
        }
        public void HienThiDSSach(DataGridView dg)
        {
            dg.DataSource = dSach.LayDSSach();
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


        public void LayDSLoaiSach(ComboBox cb)
        {
            cb.DataSource = dSach.LayDSLoaiSach();
            cb.DisplayMember = "Loaisach";
            cb.ValueMember = "Loaisach";
        }


        public bool TaoSach(Sach S)
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



        public bool SuaSach(Sach n)
        {
            if (dSach.KiemTraSach(n))
            {
                try
                {
                    dSach.SuaSach(n);
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


        public bool XoaSach(Sach n)
        {
            if (dSach.KiemTraSach(n))
                try
                {
                    dSach.XoaSach(n);
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
