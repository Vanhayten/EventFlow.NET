
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EventFlow.NET.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => { Assembly.GetExecutingAssembly(); });

            return services;
        }
    }
}
