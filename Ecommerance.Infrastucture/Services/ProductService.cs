using AutoMapper;
using Ecommerance.Infrastucture.Interfaces;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ecommerance.Core.Domain;

namespace Ecommerance.Infrastucture.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductDefinitionRepository _productDefinitionRepository;
        private readonly IAsyncRepository<ProductAvailability> _productAvailabilityRepository;
        private readonly IAsyncRepository<Color> _colorRepository;
        private readonly IAsyncRepository<Size> _sizeRepository;
        private readonly IAsyncRepository<ProductFoto> _productFotoRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, IProductDefinitionRepository productDefinitionRepository, IAsyncRepository<ProductAvailability> productAvailabilityRepository, IAsyncRepository<Color> colorRepository, IAsyncRepository<Size> sizeRepository, IAsyncRepository<ProductFoto> productFotoRepository, IMapper mapper, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _productDefinitionRepository = productDefinitionRepository;
            _productAvailabilityRepository = productAvailabilityRepository;
            _colorRepository = colorRepository;
            _sizeRepository = sizeRepository;
            _productFotoRepository = productFotoRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task AddAsync(ProductDetailsDTO product) // Dodaje nowy produkt
        {
            _logger.LogInformation(1, $"Tworze product o guid {product.Id}");
            
            //Sprawdzam czy ProductDefinition istnieje
            //Jak nie istnieje dodaje
            var productDefinition = await _productDefinitionRepository.CreateIfNullAsync(product.Name, 
                                                    product.Description, product.Mark,product.Collection, product.IsAvaible);
            //Sprawdzam czy istnieje identyczny produkt
            //Jak tak podaj błąd
            var Product = await _productRepository.GetProductByDefinitionSizeAndColorAsync(productDefinition.Id,
                                                    product.SizeId, product.ColorId);
            if (Product != null)
            {
                _logger.LogError(1, $"Product named: '{product.Name}' and colorId : '{product.ColorId}' and sizeId : '{product.SizeId}' already exist");
                throw new Exception($"Product named: '{product.Name}' and colorId : '{product.ColorId}' and sizeId : '{product.SizeId}' already exist");
               
            }
            //Sprawdzam czy jest choć jedno zdjęcie
            if(product.ProductFotosDTO.Count == 0)
            {
                _logger.LogError(1, $"Product named: '{product.Name}' doesn't have any picture. Stop process of adding product.");
                throw new Exception ($"Product named: '{product.Name}' doesn't have any picture");
            }
            //Dodaje product
            var ColorValue = await _colorRepository.GetByIdAsync(product.ColorId);
            var SizeValue = await _sizeRepository.GetByIdAsync(product.SizeId);

            Product = new Product(product.Id, product.IsAvaible, product.Discount, ColorValue.Name, SizeValue.Name, productDefinition.Id, product.SizeId, product.ColorId,product.CategoryId,product.Price);
            
            Task AddProduct =  _productRepository.AddAsync(Product);
            await AddProduct;

            //Dodaje dotepnosc produktu
            Task.WaitAll(AddProduct);
            var ProductAvailability = new ProductAvailability(Guid.NewGuid(), product.Quantity, product.Id);
            await _productAvailabilityRepository.AddAsync(ProductAvailability);
            //Dodaje zdjęcia
            int Index = 1;
            foreach (var productFoto in product.ProductFotosDTO)
            {
                var newFoto = new ProductFoto(Guid.NewGuid(), product.Id, productDefinition.Id, productFoto.FotoUrl, productFoto.Description, Index);
                Index++;
                await _productFotoRepository.AddAsync(newFoto);
            }
        }
         
        public async Task<ProductDetailsDTO> GetAsync(Guid id) // chce wyswieltic go na stronie 
        {
            _logger.LogDebug(1, $"Pobieram product o guid {id}");
            var product = await _productRepository.GetProductDetailsAsync(id);
            return _mapper.Map<ProductDetailsDTO>(product);
        }
    }
}
