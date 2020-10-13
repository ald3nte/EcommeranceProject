using System;
using System.Collections.Generic;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class Product : Entity
    {
        public int IsAvaible { get; set; }
        public double Discount { get; set; }
        public string ColorValue { get; set; }
        public string SizeValue { get; set; }
        public double Price { get; set; }
        public Guid ProductDefinitionId { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid CategoryId { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAvailability ProductAvailability { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductFoto> ProductFotos { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(Guid id, int isAvaible, double discount, string colorValue, string sizeValue, Guid productDefinitionId, Guid sizeId, Guid colorId, Guid categoryId, double price)
        {
            Id = id;
            IsAvaible = isAvaible;
            Discount = discount;
            ColorValue = colorValue;
            SizeValue = sizeValue;
            ProductDefinitionId = productDefinitionId;
            SizeId = sizeId;
            ColorId = colorId;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
            CategoryId = categoryId;
            Price = price;
        }
    }
}
