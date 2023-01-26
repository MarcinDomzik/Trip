using MediatR.Pipeline;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Trip.Application.Common.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Trip.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());                     //walidacja requestów
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));       //
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));    //
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));     //

            return services;
        }
    }
}
