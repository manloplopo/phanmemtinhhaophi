﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phanmemtinhhaophi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class phanmemtinhhaophivatlieuxaydungEntities : DbContext
    {
        public phanmemtinhhaophivatlieuxaydungEntities()
            : base("name=phanmemtinhhaophivatlieuxaydungEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Congtrinh> Congtrinh { get; set; }
        public virtual DbSet<Congtrinh_Congviec> Congtrinh_Congviec { get; set; }
        public virtual DbSet<Congviec> Congviec { get; set; }
        public virtual DbSet<Dinhmuc> Dinhmuc { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Vattu> Vattu { get; set; }
    }
}
