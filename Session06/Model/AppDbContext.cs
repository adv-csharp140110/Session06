using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Session06.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Model
{
    public  class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var appSetting = Program.Configuration.GetSection("AppSettings").Get<AppSettings>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ADVCS_140110;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<Province>()
            //    .Property(x => x.Name)
            //    .HasMaxLength(50)
            //    .IsRequired(true)
            //    .HasComment("نام");
            //modelBuilder.Entity<Province>()
            //    .Property(x => x.Id)
            //    .HasComment("شناسه");

            //modelBuilder.ApplyConfiguration(new ProvinceConfig());
            //modelBuilder.ApplyConfiguration(new CountryConfig());
            //modelBuilder.ApplyConfiguration(new CityConfig());\

            

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Reflection


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> cities { get; set; }
    }
}
