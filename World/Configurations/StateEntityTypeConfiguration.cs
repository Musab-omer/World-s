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
    public class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasMany(s => s.Cities)
                .WithOne(c => c.State);
            builder.Property(s => s.EName).HasColumnName("EnglishName")
                .HasMaxLength(50)
                .IsRequired(true);
            builder.Property(s => s.AName).HasColumnName("ArabicName")
                .HasMaxLength(50)
                .IsRequired(false);
        }
    }
}
