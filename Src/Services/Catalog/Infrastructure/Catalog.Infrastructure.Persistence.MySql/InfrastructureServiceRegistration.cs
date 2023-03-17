using Catalog.Domain.Products.Interfaces;
using Catalog.Infrastructure.Persistence.MySql.Context;
using Catalog.Infrastructure.Persistence.MySql.Infrastructure.Products.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure.Persistence.MySql
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
