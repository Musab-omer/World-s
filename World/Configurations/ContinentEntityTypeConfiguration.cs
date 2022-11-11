using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Models;

namespace World.Configurations
{
    public class ContinentEntityTypeConfiguration : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasMany(c => c.Regions)
                .WithOne(r => r.Continent);

            builder.Property(c => c.EName).HasColumnName("EnglishName").HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.AName).HasColumnName("ArabicName").HasMaxLength(30).IsRequired(false);

            //builder.HasData(new Continent {  EName = "Asia" },
            //    new Continent {  EName = "Africa" },
            //    new Continent {  EName = "Europe" },
            //    new Continent { EName = "North America" },
            //    new Continent {  EName = "South America" },
            //    new Continent {  EName = "Australia" },
            //    new Continent {  EName = "Antarctica" });
        }
    }
}
