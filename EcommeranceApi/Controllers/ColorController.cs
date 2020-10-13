using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerance.Infrastucture.Commands;
using Ecommerance.Infrastucture.DTO;
using Ecommerance.Infrastucture.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace EcommeranceApi.Controllers
{
    [Route("[Controller]")]
    public class ColorController : ApiControllerBase
    {

        private readonly IColorService _colorService;
        private readonly IMemoryCache _cache;
        private readonly IMapper _mapper;

        public ColorController(IColorService colorservice, IMemoryCache cache, IMapper mapper)
        {
            _colorService = colorservice;
            _cache = cache;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var sizes = _cache.Get<IEnumerable<ColorDTO>>("colors");
            if (sizes == null)
            {
                sizes = await _colorService.GetAllColorsAsync();
                _cache.Set("colors", sizes, TimeSpan.FromMinutes(1));
            }


            return Json(sizes);
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] CreateColor command)
        {
            command.Id = Guid.NewGuid();
            await _colorService.AddAsync(_mapper.Map<ColorDTO>(command));
            return Created($"/events/{command.Id}", null);
        }
    }
}