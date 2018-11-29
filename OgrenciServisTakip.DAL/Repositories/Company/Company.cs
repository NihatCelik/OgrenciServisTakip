using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using OgrenciServisTakip.Model.Company;

namespace OgrenciServisTakip.DAL.Repositories.Company
{
    public class ResporitoryCompany: Repository<Model.Company.Company>
    {
        public ResporitoryCompany(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Model.Company.Company> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<Model.Company.Company> List(Expression<Func<Model.Company.Company, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override Model.Company.Company GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override void Add(Model.Company.Company entity)
        {
            base.Add(entity);
        }

        public override void Update(Model.Company.Company entity)
        {
            base.Update(entity);
        }

        public override void Delete(Model.Company.Company entity)
        {
            base.Delete(entity);
        }  
    }
}
