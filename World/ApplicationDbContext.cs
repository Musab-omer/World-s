using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Configurations;
using World.Models;

namespace World
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorldDb;Integrated Security=True");

            options.UseSqlServer("Data Source=.;Initial Catalog=WorldDb;User Id=sa;Password=1234;TrustServerCertificate=True");
            options.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContinentEntityTypeConfiguration).Assembly);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RegionEntityTypeConfiguration).Assembly);
        }

        public DbSet<Continent> Continents { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
