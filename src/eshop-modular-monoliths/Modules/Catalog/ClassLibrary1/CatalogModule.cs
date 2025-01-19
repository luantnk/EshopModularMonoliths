using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container
            // services
            //     .AddApplicationServices()
            //     .AddInfrastructureServices(configuration);
            //     .AddApiServices(configuration);
            return services;
        }

        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline
            //app
            // .UseApplicationServices()
            // .UseInfrastructureServices();
            // .UseApiServices();
            return app;
        }
    }
}
