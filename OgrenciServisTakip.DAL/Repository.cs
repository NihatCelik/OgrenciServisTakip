using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciServisTakip.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;            
        }

        public virtual T GetByID(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

        public virtual void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
    }
}
