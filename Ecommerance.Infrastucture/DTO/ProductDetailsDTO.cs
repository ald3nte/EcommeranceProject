using Ecommerance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.DTO
{
    public class ProductDetailsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mark { get; set; }
        public string Collection { get; set; }
        public int IsAvaible { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<ProductFotoDTO> ProductFotosDTO { get; set; }


    }
}
