
using EcommeranceWebApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcommeranceWebApp.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllRecentProductsAsync();
        Task<IEnumerable<Product>> GetProductList(string sort=null);
    }
}
