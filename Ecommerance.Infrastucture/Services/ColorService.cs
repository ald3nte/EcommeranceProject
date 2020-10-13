using AutoMapper;
using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.DTO;
using Ecommerance.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Services
{
    public class ColorService:IColorService
    {

        public IAsyncRepository<Color> _colorRepository;
        public IMapper _mapper;

        public ColorService(IAsyncRepository<Color> colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(ColorDTO color)
        {
            Color Color = new Color(Guid.NewGuid(), color.Name, color.Description, color.HexCode, color.ImageColorUrl);
            await _colorRepository.AddAsync(_mapper.Map<Color>(color));
        }

        public async Task<IEnumerable<ColorDTO>> GetAllColorsAsync()
        {
           IEnumerable<Color> colorList = await _colorRepository.ListAllAsync();
            return _mapper.Map<IEnumerable<ColorDTO>>(colorList);
        }
    }
}
