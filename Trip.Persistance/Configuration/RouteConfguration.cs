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
    public class RouteConfguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.Property(x => x.Desc).HasMaxLength(250).IsRequired();
        }
    }
}
