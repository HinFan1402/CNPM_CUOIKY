﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYSACH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLYSACHNEWEntities : DbContext
    {
        public QLYSACHNEWEntities()
            : base("name=QLYSACHNEWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCTHD> tCTHDs { get; set; }
        public virtual DbSet<tDAILY> tDAILies { get; set; }
        public virtual DbSet<tHOADON> tHOADONs { get; set; }
        public virtual DbSet<tNHAXUATBAN> tNHAXUATBANs { get; set; }
        public virtual DbSet<tSACH> tSACHes { get; set; }
    }
}
