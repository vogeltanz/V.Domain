using System;
using System.Collections.Generic;
using System.Text;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Base.Entities
{
    public abstract class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
