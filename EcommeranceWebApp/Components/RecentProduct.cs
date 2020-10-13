using AutoMapper;
using EcommeranceWebApp.Models;
using EcommeranceWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EcommeranceWebApp.Components
{
    public class RecentProduct :ViewComponent
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public RecentProduct(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productRepository.GetAllRecentProductsAsync();
            return View(_mapper.Map<IEnumerable<ProductDetailsDTO>>(products));
        }
    }
}
