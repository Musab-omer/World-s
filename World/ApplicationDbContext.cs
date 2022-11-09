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
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorldDb;Integrated Security=True");
            options.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContinentEntityTypeConfiguration).Assembly);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RegionEntityTypeConfiguration).Assembly);
        }

        public DbSet<Continent> Contients { get; set; }
    }
}
