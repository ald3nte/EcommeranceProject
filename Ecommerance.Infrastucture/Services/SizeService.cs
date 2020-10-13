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
    public class SizeService : ISizeService
    {

        IAsyncRepository<Size> _sizeRepository;
        IMapper _mapper;

        public SizeService(IAsyncRepository<Size> sizeRepository, IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }

        public async Task AddSizeAsync(SizeDTO size)
        {
            Size Size = new Size(Guid.NewGuid(), size.Name, size.Description, size.Details);
            await _sizeRepository.AddAsync(Size);
        }

        public async Task<IEnumerable<SizeDTO>> GetAllSizesAsync()
        {

            var sizes = await _sizeRepository.ListAllAsync();



            return _mapper.Map<IEnumerable<SizeDTO>>(sizes);
        }
    }
}
