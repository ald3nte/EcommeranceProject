using Ecommerance.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Interfaces
{
    public interface IColorService
    {
        Task AddAsync(ColorDTO color);
        Task<IEnumerable<ColorDTO>> GetAllColorsAsync();
    }
}
