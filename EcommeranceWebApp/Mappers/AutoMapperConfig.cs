using AutoMapper;
using EcommeranceWebApp.Domain;
using EcommeranceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcommeranceWebApp.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDetailsDTO>()
                .ForMember(x => x.Name, m => m.MapFrom(p => p.ProductDefinition.Name))
                .ForMember(x => x.Description, m => m.MapFrom(p => p.ProductDefinition.Description))
                .ForMember(x => x.Mark, m => m.MapFrom(p => p.ProductDefinition.Mark))
                .ForMember(x => x.Collection, m => m.MapFrom(p => p.ProductDefinition.Collection))
                .ForMember(x => x.Quantity, m => m.MapFrom(p => p.ProductAvailability.Quantity))
                .ForMember(x => x.ProductFotosDTO, m => m.MapFrom(p => p.ProductFotos));

                cfg.CreateMap<Product, ProductToList>()
                .ForMember(x => x.Name, m => m.MapFrom(p => p.ProductDefinition.Name))
                .ForMember(x => x.ProductFoto, m => m.MapFrom(p => p.ProductFotos.FirstOrDefault(p=>p.Index ==1)));

                cfg.CreateMap<ProductFoto, ProductFotoDTO>();
            })
            .CreateMapper();
    }
}
