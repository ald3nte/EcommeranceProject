using Ecommerance.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.Commands
{
    public class CreateProduct
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public string Mark { get;  set; }
        public string Collection { get;  set; }
        public decimal Discount { get;  set; }
        public double Price { get; set; }
        public int Quantity { get;  set; }
        public Guid SizeId { get;  set; }
        public Guid ColorId { get;  set; }
        public Guid CategoryId { get; set; }
        public ICollection<ProductFotoDTO> ProductFotos { get; set; }
    }
}
