using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Core.Domain
{
    public class Size : Entity
    {
        public string Name { get; set; }
        public string  Description { get; set; }
        public string Details { get; set; }

        public ICollection<Product> Products { get; set; }
        public Size(Guid id,string name, string description, string details)
        {
            Id = id;
            Name = name;
            Description = description;
            Details = details;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
    }
}
