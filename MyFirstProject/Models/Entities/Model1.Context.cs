﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstProject.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbShopperProjectEntities : DbContext
    {
        public DbShopperProjectEntities()
            : base("name=DbShopperProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAbout> TblAbout { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblContact> TblContact { get; set; }
        public virtual DbSet<TblCustomers> TblCustomers { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
    }
}