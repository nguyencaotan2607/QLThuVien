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
    
    public partial class Nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
        public string Tk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPM> CTPMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Docgia> Docgias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
        public virtual Taikhoan Taikhoan { get; set; }
    }
}