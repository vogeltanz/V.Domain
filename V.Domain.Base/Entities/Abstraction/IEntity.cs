using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Base.Entities.Abstraction
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}
