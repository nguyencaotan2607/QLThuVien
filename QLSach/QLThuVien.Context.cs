﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLThuVienEntities : DbContext
    {
        public QLThuVienEntities()
            : base("name=QLThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CTPM> CTPMs { get; set; }
        public DbSet<Docgia> Docgias { get; set; }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Phieumuon> Phieumuons { get; set; }
        public DbSet<Sach> Saches { get; set; }
    }
}
