using System.Collections.Generic;
using Catalog.Application.Features.Products.QueryView;
using MediatR;

namespace Catalog.Application.Features.Products.Queries
{
    public class GetAllProductQuery:IRequest<IEnumerable<GetAllProductQueryView>>
    {
    }
}
