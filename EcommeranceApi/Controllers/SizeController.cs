using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerance.Infrastucture.Commands;
using Ecommerance.Infrastucture.DTO;
using Ecommerance.Infrastucture.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace EcommeranceApi.Controllers
{
    [Route("[Controller]")]
    public class SizeController : ApiControllerBase
    {
        private readonly ISizeService _sizeService;
        private readonly IMemoryCache _cache;
        private readonly IMapper _mapper;

        public SizeController(ISizeService sizeService, IMemoryCache cache, IMapper mapper)
        {
            _sizeService = sizeService;
            _cache = cache;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var sizes = _cache.Get<IEnumerable<SizeDTO>>("sizes");
            if (sizes == null)
            {
                sizes = await _sizeService.GetAllSizesAsync();
                _cache.Set("sizes", sizes, TimeSpan.FromMinutes(1));
            }


            return Json(sizes);
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] CreateSize command)
        {
            command.Id = Guid.NewGuid();
            await _sizeService.AddSizeAsync(_mapper.Map<SizeDTO>(command));
            return Created($"/events/{command.Id}", null);
        }
    
    }
}