﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlybanvemaybay1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyVeMayBayEntities1 : DbContext
    {
        public QuanLyVeMayBayEntities1()
            : base("name=QuanLyVeMayBayEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETCHUYENBAY> CHITIETCHUYENBAYs { get; set; }
        public virtual DbSet<CHUYENBAY> CHUYENBAYs { get; set; }
        public virtual DbSet<GOIHANHLY> GOIHANHLies { get; set; }
        public virtual DbSet<HANGKHOANG> HANGKHOANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<PHIEUDATVE> PHIEUDATVEs { get; set; }
        public virtual DbSet<PHIEUDOIHUYVE> PHIEUDOIHUYVEs { get; set; }
        public virtual DbSet<PHIEUKYGUIHANHLY> PHIEUKYGUIHANHLies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VEMAYBAY> VEMAYBAYs { get; set; }

        public System.Data.Entity.DbSet<Quanlybanvemaybay1.Models.LoginModel> LoginModels { get; set; }
    }
}
