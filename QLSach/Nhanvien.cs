//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            this.CTPMs = new HashSet<CTPM>();
            this.Docgias = new HashSet<Docgia>();
            this.Phieumuons = new HashSet<Phieumuon>();
        }
    
        public string Manv { get; set; }
        public string Tennv { get; set; }
        public Nullable<System.DateTime> Namsinh { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public Nullable<System.DateTime> Ngaylamviec { get; set; }
    
        public virtual ICollection<CTPM> CTPMs { get; set; }
        public virtual ICollection<Docgia> Docgias { get; set; }
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
    }
}
