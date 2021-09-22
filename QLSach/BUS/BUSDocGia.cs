using QLSach.Commons;
using QLSach.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach.BUS
{

    class BUSDocGia
    {
        DAODocGia dDocGia;

        public BUSDocGia()
        {
            dDocGia = new DAODocGia();
        }

        public void HienThiDSDonHang(DataGridView dg)
        {
            dg.DataSource = dDocGia.LayDSDocGia();
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].HeaderText = Ten.ten[i];
            }
        }

        public void LayDSNhanVien(ComboBox cb)
        {
            cb.DataSource = dDocGia.LayDSNV();
            cb.DisplayMember = "Tennv";
            cb.ValueMember = "Manv";
        }

        public bool KTMadg(Docgia dg)
        {
            return dDocGia.KiemTraDG(dg);
        }

        public bool TaoDG(Docgia d)
        {
            dDocGia.ThemDG(d);
            return true;
        }

        public bool SuaDH(Docgia d)
        {
            if (dDocGia.KiemTraDG(d))
            {
                try
                {
                    dDocGia.SuaDH(d);
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

        public bool XoaDH(Docgia d)
        {
            if (dDocGia.KiemTraDG(d))
            {
                try
                {
                    dDocGia.XoaDH(d);
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
    }
}
