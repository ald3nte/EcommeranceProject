using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommeranceWebApp.Models
{
    public class ProductToList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedAt { get; set; }
        public ProductFotoDTO ProductFoto { get; set; }
    }
}
