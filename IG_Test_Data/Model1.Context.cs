﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IG_Test_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IELTS_GiaSuEntities : DbContext
    {
        public IELTS_GiaSuEntities()
            : base("name=IELTS_GiaSuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<IG_Login_Service> IG_Login_Service { get; set; }
        public virtual DbSet<IG_Rating_Login_Service> IG_Rating_Login_Service { get; set; }
        public virtual DbSet<IG_Service> IG_Service { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
