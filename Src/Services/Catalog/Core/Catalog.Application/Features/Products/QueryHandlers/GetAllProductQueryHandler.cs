using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.Application.Features.Products.Queries;
using Catalog.Application.Features.Products.QueryView;
using Catalog.Domain.Products.Interfaces;
using MediatR;

namespace Catalog.Application.Features.Products.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<GetAllProductQueryView>>
    {
        #region Constractor
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        #endregion

        #region Handler
        public async Task<IEnumerable<GetAllProductQueryView>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var productList = await _productRepository.GetAll();
            return _mapper.Map<List<GetAllProductQueryView>>(productList);
        }
        #endregion
    }
}
