using Application.Application.Services;
using Application.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Infra.Data.Repositories;

namespace Infra.IoC.Extension
{
    public static class DependencyInjectorExtension
    {
        public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
        {
            // AppService
            services.AddScoped<IJsonDataAppService, JsonDataAppService>();

            // Service
            services.AddScoped<IJsonDataService, JsonDataService>();

            // Repository
            services.AddScoped<IJsonDataRepository, JsonDataRepository>();
            return services;
        }
    }
}
