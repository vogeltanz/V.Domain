using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Base.Repository
{
    public interface ITransaction
    {
        void CreateTransaction();
        void Commit();
        void Rollback();
    }
}
