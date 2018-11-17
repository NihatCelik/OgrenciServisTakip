using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OgrenciServisTakip.DAL
{
    public interface IRepository<T>
    {
        T GetByID(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
