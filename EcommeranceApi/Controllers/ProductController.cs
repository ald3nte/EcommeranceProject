using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerance.Infrastucture.Interfaces;
using Ecommerance.Infrastucture.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Ecommerance.Infrastucture.Commands;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace EcommeranceApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMemoryCache _cache;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMemoryCache cache, IMapper mapper)
        {
            _productService = productService;
            _cache = cache;
            _mapper = mapper;
        }
        [AllowAnonymous]
        [HttpGet("{Id}")] // Pobieranie produktu po ID
        public async Task<IActionResult> Get(Guid id)
        {
            var product = await _productService.GetAsync(id);

            return Json(product);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateProduct command)
        {
            command.Id = Guid.NewGuid();
            await _productService.AddAsync(_mapper.Map<ProductDetailsDTO>(command));
            return Created($"/product/{command.Id}", null);

        }
    }
}