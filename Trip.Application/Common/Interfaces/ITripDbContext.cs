using Microsoft.EntityFrameworkCore;
using Trip.Domain.Entities;
//using SkmoB.Domain.Entities;

namespace Trip.Application.Common.Interfaces
{
    public interface ITripDbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Tour> Tour { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
