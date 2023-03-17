using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.Application.Features.Products.Commands;
using Catalog.Domain.Products.Entities;
using Catalog.Domain.Products.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.Features.Products.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,long>
    {
        #region Constractor
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateProductCommandHandler> _logger;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, ILogger<CreateProductCommandHandler> logger)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _logger = logger;
        }
        #endregion

        #region Handler
        public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var productEntity = _mapper.Map<Product>(request);
                await _productRepository.Create(productEntity);
                _logger.LogInformation("Product 0 is successfully created.");
                return 0;
            }
            catch (Exception e)
            {
                _logger.LogError("Product 0 is created error.");
                return -1;
            }
        }
        #endregion
    }
}
