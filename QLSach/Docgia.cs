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
    
    public partial class Docgia
    {
        public Docgia()
        {
            this.CTPMs = new HashSet<CTPM>();
        }
    
        public string Madg { get; set; }
        public string Tendg { get; set; }
        public Nullable<System.DateTime> Namsinh { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string Lop { get; set; }
        public Nullable<System.DateTime> Ngaytaothe { get; set; }
        public string Manv { get; set; }
    
        public virtual ICollection<CTPM> CTPMs { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}
