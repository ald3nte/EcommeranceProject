using AutoMapper;
using Ecommerance.Core.Domain;
using Ecommerance.Infrastucture.Commands;
using Ecommerance.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.Mappers
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


                cfg.CreateMap<ProductFoto, ProductFotoDTO>();
                cfg.CreateMap<CreateProduct, ProductDetailsDTO>()
                .ForMember(x => x.ProductFotosDTO, m => m.MapFrom(p => p.ProductFotos));
                cfg.CreateMap<Color, ColorDTO>();
                cfg.CreateMap<ColorDTO, Color>();
                cfg.CreateMap<CreateColor, ColorDTO>();
                cfg.CreateMap<Size, SizeDTO>();
                cfg.CreateMap<SizeDTO, Size>();
                cfg.CreateMap<CreateSize, SizeDTO>();
                cfg.CreateMap<User, AccountDTO>();
            })
            .CreateMapper();
    }
}
