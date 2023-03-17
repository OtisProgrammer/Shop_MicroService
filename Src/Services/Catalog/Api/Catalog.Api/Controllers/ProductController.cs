using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Catalog.Application.Features.Products.Commands;
using Catalog.Application.Features.Products.Queries;
using Catalog.Application.Features.Products.QueryView;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet( "GetAll")]
        [ProducesResponseType(typeof(IEnumerable<GetAllProductQueryView>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GetAllProductQueryView>>> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductQuery());
            return Ok(products);
        }

        [HttpPost(Name = "Create")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> Create([FromBody] CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
