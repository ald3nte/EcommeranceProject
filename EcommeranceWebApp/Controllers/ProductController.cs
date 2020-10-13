using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using EcommeranceWebApp.Domain;
using EcommeranceWebApp.Helpers;
using EcommeranceWebApp.Models;
using EcommeranceWebApp.Repositories;
using EcommeranceWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;

namespace EcommeranceWebApp.Controllers
{
    public class ProductController : Controller
    {
        private IConnectionApiClient _api;
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductController(IConnectionApiClient api, IProductRepository productRepository, IMapper mapper)
        {
            _api = api;
            _productRepository = productRepository;
            _mapper = mapper;
        }


        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ProductPage(Guid ProductGUID)
        {
            var productDetailsViewModel = new ProductDescriptionViewModel();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"product/{ProductGUID}");
            string results = "";
            if(res.IsSuccessStatusCode)
            {
                results = res.Content.ReadAsStringAsync().Result;
                productDetailsViewModel.Product = JsonConvert.DeserializeObject<ProductDetailsDTO>(results);
            }
            return View(productDetailsViewModel);
        }

         public async Task<IActionResult> AllProducts(string sort = null)
        {
            var ProductsViewModel = new AllProductsViewModel();

            var products = await _productRepository.GetProductList(sort);
            ProductsViewModel.Products = _mapper.Map<IEnumerable<ProductToList>>(products);
            return View(ProductsViewModel);
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
    }
}
