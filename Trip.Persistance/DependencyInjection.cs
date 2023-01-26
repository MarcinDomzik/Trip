using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trip.Application.Common.Interfaces;


namespace Trip.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TripDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TripDbConn")));

            services.AddScoped<ITripDbContext, TripDbContext>();
            return services;
        }
    }
}
