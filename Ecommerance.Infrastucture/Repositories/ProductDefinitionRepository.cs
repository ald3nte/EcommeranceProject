using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Repositories
{
    public class ProductDefinitionRepository :  EfRepository<ProductDefinition>, IProductDefinitionRepository
    {

        private readonly ILogger<ProductDefinitionRepository> _logger;
        private readonly AppDbContext _appDbContext;
        public ProductDefinitionRepository(ILogger<ProductDefinitionRepository> logger, AppDbContext appDbContext) : base(appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        public async Task<ProductDefinition> GetAsync(string name)
        {
            return await _appDbContext.Set<ProductDefinition>().FirstOrDefaultAsync(x => x.Name == name);

        }

        public async Task<ProductDefinition> CreateIfNullAsync(string name,string description, string mark,string collection,int isAvaible)
        {
            var productDefinition = await GetAsync(name);
            if (productDefinition == null)
            {

                productDefinition = new ProductDefinition(Guid.NewGuid(), name, description, mark, collection, isAvaible);
                _logger.LogDebug(1, $"Nie istnieje taki productDefinition dodaje: {productDefinition.Id}");
                await AddAsync(productDefinition);
            }
            return productDefinition;
        }
    }
}
