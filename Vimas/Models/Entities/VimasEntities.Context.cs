﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vimas.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VimasEntities : DbContext
    {
        public VimasEntities()
            : base("name=VimasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BangCap> BangCaps { get; set; }
        public virtual DbSet<CongTyChungNghe> CongTyChungNghes { get; set; }
        public virtual DbSet<CongTyTiepNhan> CongTyTiepNhans { get; set; }
        public virtual DbSet<HopDongDOLAB> HopDongDOLABs { get; set; }
        public virtual DbSet<HopDongDOLABHocVienMapping> HopDongDOLABHocVienMappings { get; set; }
        public virtual DbSet<KyTucXa> KyTucXas { get; set; }
        public virtual DbSet<NghiepDoan> NghiepDoans { get; set; }
        public virtual DbSet<QuaTrinhHocTap> QuaTrinhHocTaps { get; set; }
        public virtual DbSet<QuaTrinhLamViec> QuaTrinhLamViecs { get; set; }
        public virtual DbSet<SucKhoe> SucKhoes { get; set; }
        public virtual DbSet<SystemLog> SystemLogs { get; set; }
        public virtual DbSet<ThongTinCaNhan> ThongTinCaNhans { get; set; }
        public virtual DbSet<ThongTinDuTuyen> ThongTinDuTuyens { get; set; }
        public virtual DbSet<ThongTinGiaDinh> ThongTinGiaDinhs { get; set; }
        public virtual DbSet<ThongTinNopTien> ThongTinNopTiens { get; set; }
        public virtual DbSet<ThongTinPhongVan> ThongTinPhongVans { get; set; }
        public virtual DbSet<ThongTinVeNuoc> ThongTinVeNuocs { get; set; }
        public virtual DbSet<TrungTamGTVL> TrungTamGTVLs { get; set; }
    }
}
