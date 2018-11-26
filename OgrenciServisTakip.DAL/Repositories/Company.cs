using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using OgrenciServisTakip.Model.Company;

namespace OgrenciServisTakip.DAL.Repositories
{
    public class ResporitoryCompany: Repository<Company>
    {
        public ResporitoryCompany(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Company> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<Company> List(Expression<Func<Company, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override Company GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override void Add(Company entity)
        {
            base.Add(entity);
        }

        public override void Update(Company entity)
        {
            base.Update(entity);
        }

        public override void Delete(Company entity)
        {
            base.Delete(entity);
        }  
    }
}
