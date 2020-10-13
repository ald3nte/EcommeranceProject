using System;
using System.Collections.Generic;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class ProductAvailability : Entity
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public ProductAvailability(Guid id,int quantity, Guid productId)
        {
            Id = id;
            Quantity = quantity;
            ProductId = productId;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
    }
}
