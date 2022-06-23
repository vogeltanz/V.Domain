using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Base.Repository
{
    public interface IUnitOfWork
    {
        void CreateTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();
    }
}
