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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.Mark).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Model).HasMaxLength(50).IsRequired();
            builder.Property(x => x.FuelType).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Transmission).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Colour).HasMaxLength(25).IsRequired();
        }
    }
}
