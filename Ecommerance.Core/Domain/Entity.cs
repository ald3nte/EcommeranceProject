using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Core.Domain
{
   public class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime EditedAt { get; protected set; }
    }
}
