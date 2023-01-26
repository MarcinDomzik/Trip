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
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.Property(x => x.FName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.DrLincense).HasMaxLength(25);
        }
    }
}
