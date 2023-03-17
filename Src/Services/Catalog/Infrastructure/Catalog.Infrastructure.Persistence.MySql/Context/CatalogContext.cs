using Catalog.Domain.Products.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Persistence.MySql.Context
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["DatabaseSettings:ConnectionString"]);
            var database = client.GetDatabase("DatabaseSettings:DatabaseName");
            Product = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
            //CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Product { get; }
    }
}
