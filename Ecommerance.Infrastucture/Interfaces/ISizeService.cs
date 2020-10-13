using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Interfaces
{
    public interface ISizeService
    {
        Task<IEnumerable<SizeDTO>> GetAllSizesAsync();

        Task AddSizeAsync(SizeDTO size);

    }
}
