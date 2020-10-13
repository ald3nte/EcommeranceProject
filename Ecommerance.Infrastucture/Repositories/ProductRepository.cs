using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using System.Linq;
using Ecommerance.Infrastucture.Helpers;

namespace Ecommerance.Infrastucture.Repositories
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

        public async Task<IReadOnlyList<Product>> GetAllAvaibleItemsAsync()
        {
            return await _appDbContext.Set<Product>().Where(s => s.IsAvaible == 1).ToListAsync();
            
        }

        public async Task<Product> GetProductDetailsAsync(Guid id)
        {
            return await _appDbContext.Set<Product>()
                    .Include(c => c.ProductDefinition)
                    .Include( c=> c.ProductFotos)
                    .FirstOrDefaultAsync(c => c.Id == id);
        }
        
        public async Task<Product> GetProductByDefinitionSizeAndColorAsync(Guid productDefinitionId,Guid sizeId,Guid colorId)
        {
            return await _appDbContext.Set<Product>()
                    .Where(c=> c.SizeId == sizeId )
                    .Where(c=> c.ColorId == colorId)
                    .Where(c=> c.ProductDefinitionId == productDefinitionId)
                    .FirstOrDefaultAsync();
        }



    }
}
