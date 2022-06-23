using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Base.Repository
{
    public interface IRepository<T, TKey> where T : IEntity<TKey>
    {
        T GetById(TKey id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }

}
