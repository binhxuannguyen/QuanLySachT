﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySachT.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demoQLSTEntities : DbContext
    {
        public demoQLSTEntities()
            : base("name=demoQLSTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BaoCaoBanHang> BaoCaoBanHangs { get; set; }
        public DbSet<CT_BaoCaoBanHang> CT_BaoCaoBanHang { get; set; }
        public DbSet<CT_PhieuGhiNoDaiLy> CT_PhieuGhiNoDaiLy { get; set; }
        public DbSet<CT_PhieuKiemKho> CT_PhieuKiemKho { get; set; }
        public DbSet<CT_PhieuNhap> CT_PhieuNhap { get; set; }
        public DbSet<CT_PhieuXuat> CT_PhieuXuat { get; set; }
        public DbSet<CT_PhieuYeuCauBan> CT_PhieuYeuCauBan { get; set; }
        public DbSet<CT_PhieuYeuCauMua> CT_PhieuYeuCauMua { get; set; }
        public DbSet<CT_ThongKeChoNXB> CT_ThongKeChoNXB { get; set; }
        public DbSet<DaiLy> DaiLies { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<PhieuGhiNoDaiLy> PhieuGhiNoDaiLies { get; set; }
        public DbSet<PhieuKiemKho> PhieuKiemKhoes { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        public DbSet<PhieuYeuCauBan> PhieuYeuCauBans { get; set; }
        public DbSet<PhieuYeuCauMua> PhieuYeuCauMuas { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<ThongKeChoNXB> ThongKeChoNXBs { get; set; }
    }
}