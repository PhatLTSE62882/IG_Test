using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IG_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IG_Test.DataAccess.Context
{
    public class IGContext : IdentityDbContext
    {
        public IGContext(DbContextOptions<IGContext> options) : base(options)
        {
            //
        }
        

        public virtual DbSet<IG_Login_Service> IG_Login_Service { get; set; }
        public virtual DbSet<IG_Rating_Login_Service> IG_Rating_Login_Service { get; set; }
        public virtual DbSet<IG_Service> IG_Service { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IG_Login_Service>(entity =>
            {
                entity.HasKey(x => x.loginToken);
            });

            modelBuilder.Entity<IG_Rating_Login_Service>(entity =>
            {
                entity.HasKey(x => x.id);
            });

            modelBuilder.Entity<IG_Service>(entity =>
            {
                entity.HasKey(x => x.serviceCode);
            });

        }
    }
}
