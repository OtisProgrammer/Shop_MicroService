using Catalog.Domain.Common;

namespace Catalog.Domain.Products.Entities
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
