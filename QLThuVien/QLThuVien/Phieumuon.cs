//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieumuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieumuon()
        {
            this.CTPMs = new HashSet<CTPM>();
        }
    
        public string Maphieu { get; set; }
        public string Manv { get; set; }
        public Nullable<System.DateTime> Ngaylapphieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPM> CTPMs { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}