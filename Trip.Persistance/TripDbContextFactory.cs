using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Persistance;

namespace Trip.Persistance
{
    public class TripDbContextFactory : DesignTimeDbContextFactoryBase<TripDbContext>
    {
        protected override TripDbContext CreateNewInstance(DbContextOptions<TripDbContext> options)
        {
            return new TripDbContext(options);
        }
    }
}
