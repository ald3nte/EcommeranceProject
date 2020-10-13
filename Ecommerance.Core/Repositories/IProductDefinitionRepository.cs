using Ecommerance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Core.Repositories
{
    public interface IProductDefinitionRepository: IAsyncRepository<ProductDefinition>
    {
        Task<ProductDefinition> GetAsync(string name);
        Task<ProductDefinition> CreateIfNullAsync(string name, string description, string mark, string collection, int isAvaible);


    }
}
