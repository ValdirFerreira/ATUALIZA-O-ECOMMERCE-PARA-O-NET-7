using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<CompraUsuario> CompraUsuario { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<LogSistema> LogSistema { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        private string GetStringConectionConfig()
        {
             string strCon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
           // string strCon = "Server=tcp:canaldevcore.database.windows.net,1433;Initial Catalog=dev;Persist Security Info=False;User ID=valdir;Password=@Beatriz222;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return strCon;
        }


    }
}
