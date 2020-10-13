using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.DTO
{
    public class ColorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HexCode { get; set; }
        public string ImageColorUrl { get; set; }
    }
}
