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
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.CTPMs = new HashSet<CTPM>();
        }
    
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public string Loaisach { get; set; }
        public string Linhvuc { get; set; }
        public string Tacgia { get; set; }
        public string NXB { get; set; }
        public Nullable<System.DateTime> Ngayxuatban { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPM> CTPMs { get; set; }
    }
}