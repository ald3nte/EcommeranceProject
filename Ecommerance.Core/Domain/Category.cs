using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Core.Domain
{
    public class Category :Entity
    {
        public string Name { get; set; }
        public Guid ParentId { get; set; }

        public Category(Guid id,string name, Guid parentId)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
            CreatedAt = DateTime.UtcNow;
            EditedAt = DateTime.UtcNow;
        }
    }
}
