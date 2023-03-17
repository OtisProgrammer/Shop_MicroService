using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Domain.Products.Entities;

namespace Catalog.Domain.Products.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task Create(Product product);
    }
}
