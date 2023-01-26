using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Trip.Application.Common.Interfaces;
using Trip.Domain.Common;
using Trip.Domain.Entities;

namespace Trip.Persistance
{
    public class TripDbContext : DbContext, ITripDbContext
    {
        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Tour> Tour { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //dodać każdą konfiguracje znalezioną w tym assembly
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "";
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "";
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.InactivatedBy = "";
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
