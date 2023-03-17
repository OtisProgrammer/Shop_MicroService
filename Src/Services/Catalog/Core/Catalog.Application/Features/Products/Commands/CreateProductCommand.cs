using MediatR;

namespace Catalog.Application.Features.Products.Commands
{
    public class CreateProductCommand : IRequest<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
