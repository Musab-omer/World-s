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
    public class CityEntityTypeConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.EName)
                .HasColumnName("EnglishName")
                .HasMaxLength(30)
                .IsRequired(true);
            builder.Property(c => c.AName)
                .HasColumnName("ArabicName")
                .HasMaxLength(30)
                .IsRequired(true);
        }
    }
}
