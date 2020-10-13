using System;
using System.Collections.Generic;
using System.Text;

namespace EcommeranceWebApp.Domain
{
    public class Color: Entity
    {
        public string Name { get;protected set; }
        public string Description { get; protected set; }
        public string HexCode { get; protected set; }
        public string ImageColorUrl { get; protected set; }

        public ICollection<Product> Products { get; set; }
        public Color(Guid id,string name, string description, string hexCode, string imageColorUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            HexCode = hexCode;
            ImageColorUrl = imageColorUrl;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
    }
}
