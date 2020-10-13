
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommeranceWebApp.Models
{
    public class ProductDetailsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mark { get; set; }
        public string Collection { get; set; }
        public int IsAvaible { get; set;}
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime CreatedAt { get; protected set; }
        public ICollection<ProductFotoDTO> ProductFotosDTO { get; set; }


    }
}
