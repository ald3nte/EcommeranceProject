
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using EcommeranceWebApp.Domain;
using EcommeranceWebApp.Helpers;

namespace EcommeranceWebApp.Repositories
{
    public class ProductRepository : EfRepository<Product>,IProductRepository 
    {

        private readonly ILogger<ProductRepository> _logger;
        private readonly AppDbContext _appDbContext;
        public ProductRepository(ILogger<ProductRepository> logger,AppDbContext appDbContext) : base(appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetAllRecentProductsAsync()
        {
            return await _appDbContext.Set<Product>()
                    .Include(c => c.ProductAvailability)
                    .Include(c => c.ProductFotos)
                    .Include(c => c.ProductDefinition)
                    .OrderByDescending(u => u.ProductAvailability.Quantity)
                    .Take(5)
                    .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductList(string sort=null)
        {

            return await _appDbContext.Set<Product>()
                    .Include(c=> c.ProductFotos)
                    .Include(c=> c.ProductDefinition)
                    .OrderByDescending(u => u.CreatedAt)
                    .ToListAsync();
        }
    }
}
