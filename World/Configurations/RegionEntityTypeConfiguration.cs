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
    public class RegionEntityTypeConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasMany(r => r.Countries)
                .WithOne(c => c.Region);

            builder.Property(r=>r.EName).HasColumnName("EnglishName")
                .HasMaxLength(30)
                .IsRequired(true);
            builder.Property(r => r.AName).HasColumnName("ArabicName")
                .HasMaxLength(30).IsRequired(false);
        }
    }
}
