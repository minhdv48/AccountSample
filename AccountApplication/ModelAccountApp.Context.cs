﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccountAppEntities : DbContext
    {
        public AccountAppEntities()
            : base("name=AccountAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccChart> AccCharts { get; set; }
        public virtual DbSet<AccChild> AccChilds { get; set; }
        public virtual DbSet<AccDept> AccDepts { get; set; }
        public virtual DbSet<AccLedger> AccLedgers { get; set; }
        public virtual DbSet<Accnvarchart> Accnvarcharts { get; set; }
        public virtual DbSet<SetUP01> SetUP01 { get; set; }
        public virtual DbSet<SetUP02> SetUP02 { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tDept> tDepts { get; set; }
    }
}
