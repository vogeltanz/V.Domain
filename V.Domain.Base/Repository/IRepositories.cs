using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Base.Repository
{
    public interface IRepositories
    {
        Dictionary<Type, IRepository> Repositories { get; }
    }
}
