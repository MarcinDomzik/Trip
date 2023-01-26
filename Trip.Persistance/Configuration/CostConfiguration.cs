using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Domain.Entities;

namespace Trip.Persistance.Configuration
{
    internal class CostConfiguration : IEntityTypeConfiguration<Cost>
    {
        public void Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.Property(x => x.Desc).HasMaxLength(250).IsRequired();
            builder.Property(x => x.PerDay).HasPrecision(18, 2);
            builder.Property(x => x.PerKm).HasPrecision(18, 2);
            builder.Property(x => x.PerTour).HasPrecision(18, 2);
        }
    }
}
