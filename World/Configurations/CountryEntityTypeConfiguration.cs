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
    public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasMany(c => c.States)
                .WithOne(s => s.Country);
            builder.Property(c => c.EName).HasMaxLength(30)
                .HasColumnName("EnglishName")
                .IsRequired(true);
            builder.Property(c => c.AName).HasMaxLength(30)
                .HasColumnName("ArabicName")
                .IsRequired(false);
            builder.Property(c => c.Code).HasMaxLength(10)
                .IsRequired(true);
        }
    }
}
