using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using OgrenciServisTakip.Model.Company;

namespace OgrenciServisTakip.DAL.Repositories
{
    public class ResporitoryUser : Repository<User>
    {
        public ResporitoryUser(DbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(User entity)
        {
            base.Add(entity);
        }

        public override void Delete(User entity)
        {
            base.Delete(entity);
        }

        public override User GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override IEnumerable<User> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<User> List(Expression<Func<User, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(User entity)
        {
            base.Update(entity);
        }
    }
}
