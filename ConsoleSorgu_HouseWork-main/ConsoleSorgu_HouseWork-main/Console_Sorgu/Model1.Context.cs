﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console_Sorgu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KutuphaneSabahEntities : DbContext
    {
        public KutuphaneSabahEntities()
            : base("name=KutuphaneSabahEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Odunc> Odunc { get; set; }
        public DbSet<Turler> Turler { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        public DbSet<Yayinevleri> Yayinevleri { get; set; }
        public DbSet<Yazarlar> Yazarlar { get; set; }
    }
}
