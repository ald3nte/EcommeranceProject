using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class ProductDefinition : Entity
    {

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string Mark { get; protected set; }
        public string Collection { get; protected set; }
        public int IsAvaible { get; protected set; }

        public ICollection<Product> Products{get;protected set;}
        public ICollection<ProductFoto> ProductFoto { get; set; }


        protected ProductDefinition()
        {

        }

        public ProductDefinition(Guid id, string name,string description,string mark,string collection,int isAvaible)
        {
            Id = id;
            SetName(name);
            Description = description;
            Mark = mark;
            Collection = collection;
            IsAvaible = isAvaible;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception($"ProductDefinition can not have an empty name");
            }
            Name = name;
        }
    }
}
