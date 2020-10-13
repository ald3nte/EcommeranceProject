using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class ProductFoto : Entity
    {
      
        public Guid ProductId { get; protected set; }
        public Guid ProductDefinitionId { get; protected set; }
        public string  FotoUrl{ get; protected set; }
        public string Description { get; protected set; }
        public int Index { get; set; }
        public Product Product { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        protected ProductFoto ()
        {

        }

        public ProductFoto(Guid id,Guid productId,Guid productDefinitionId, string fotoUrl, string description, int index)
        {
            Id = id;
            ProductId = productId;
            ProductDefinitionId = productDefinitionId;
            FotoUrl = fotoUrl;
            Description = description;
            Index = index;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
    }
}
