using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Domain.Products.Entities;
using Catalog.Domain.Products.Interfaces;
using Catalog.Infrastructure.Persistence.MySql.Context;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Persistence.MySql.Infrastructure.Products.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ICatalogContext _context;
        public ProductRepository(ICatalogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context
                .Product
                .Find(p => true)
                .ToListAsync();
        }
        public async Task Create(Product product)
        {
            await _context.Product.InsertOneAsync(product);
        }

    }
}
