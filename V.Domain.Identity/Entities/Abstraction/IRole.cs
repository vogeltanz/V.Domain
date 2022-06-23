using System;
using System.Collections.Generic;
using System.Text;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Identity.Entities.Abstraction
{
    public interface IRole<TKey> : IEntity<TKey>
    {
        string Name { get; set; }
    }
}
