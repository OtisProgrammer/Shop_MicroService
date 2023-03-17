using Catalog.Domain.Products.Entities;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Persistence.MySql.Context
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Product { get; }
    }
}
