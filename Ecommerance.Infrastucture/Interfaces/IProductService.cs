using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Ecommerance.Infrastucture.DTO;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Interfaces
{
    public interface IProductService 
    {
        Task<ProductDetailsDTO> GetAsync(Guid id);
        Task AddAsync(ProductDetailsDTO product);  
    }
}
