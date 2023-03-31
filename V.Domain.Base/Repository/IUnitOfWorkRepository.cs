using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Base.Repository
{
    public interface IUnitOfWorkRepository : IUnitOfWork, IRepositories
    {
    }
}
