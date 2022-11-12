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

            //builder.HasData(new Continent { id-1,EName = "Asia" },
            //    new Continent {id=-2, EName = "Africa" },
            //    new Continent {id=-3, EName = "Europe" },
            //    new Continent {id=-4,EName = "North America" },
            //    new Continent {id=-5, EName = "South America" },
            //    new Continent { id=-6,EName = "Australia" },
            //    new Continent { id=-7, EName = "Antarctica" });
        }
    }
}
