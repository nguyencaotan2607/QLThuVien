using QLThuVien.Commons;
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

    class BUS_DocGia
    {
        DAO_DocGia dDocGia;

        public BUS_DocGia()
        {
            dDocGia = new DAO_DocGia();
        }

        public void HienThiDSDocGia(DataGridView dg)
        {
            dg.DataSource = dDocGia.LayDSDocGia();
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                dg.Columns[i].HeaderText = Ten.ten[i];
            }
        }

        public List<Docgia> HienThiDSDocGiaRP()
        {
            return dDocGia.LayDSDocGiaRP();
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

        public bool SuaDG(Docgia d)
        {
            if (dDocGia.KiemTraDG(d))
            {
                try
                {
                    dDocGia.SuaDG(d);
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

        public bool XoaDG(Docgia d)
        {
            if (dDocGia.KiemTraDG(d))
            {
                try
                {
                    dDocGia.XoaDG(d);
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
