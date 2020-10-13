using Ecommerance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Core.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<Product> GetProductDetailsAsync(Guid id);
        Task<IReadOnlyList<Product>> GetAllAvaibleItemsAsync();
        Task<Product> GetProductByDefinitionSizeAndColorAsync(Guid productDefinitionId, Guid sizeId, Guid colorId);


    }
}
