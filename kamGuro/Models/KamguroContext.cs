using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace kamGuro.Models
{
    public class KamguroContext : DbContext
    {
        public KamguroContext()
            : base("KamguroContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Producto> Productos { get; set; }
       
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Entity<ApplicationUser>()
            //   .ToTable("User", "dbo");
            //   .Property(p => p.Id).HasColumnName("UserID");
            //modelBuilder.Entity<IdentityRole>()
            //    .ToTable("Role", "dbo")
            //    .Property(p => p.Id).HasColumnName("RoleID");
            //modelBuilder.Entity<IdentityUserClaim>()
            //    .ToTable("UserClaim", "dbo")
            //    .Property(p => p.Id).HasColumnName("UserClaimID");
            //modelBuilder.Entity<IdentityUserLogin>()
            //    .ToTable("UserLogin", "dbo")
            //    .Property(p => p.UserId).HasColumnName("UserID");
            //modelBuilder.Entity<IdentityUserRole>()
            //    .ToTable("UserRole", "dbo")
            //    .Property(p => p.UserId).HasColumnName("UserID");
        }
    }
}