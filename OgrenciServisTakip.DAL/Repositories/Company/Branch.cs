using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using OgrenciServisTakip.Model.Company;

namespace OgrenciServisTakip.DAL.Repositories.Company
{
    public class ResporitoryBranch: Repository<Branch>
    {
        public ResporitoryBranch(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Branch> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<Branch> List(Expression<Func<Branch, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override Branch GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override void Add(Branch entity)
        {
            base.Add(entity);
        }

        public override void Update(Branch entity)
        {
            base.Update(entity);
        }

        public override void Delete(Branch entity)
        {
            base.Delete(entity);
        }  
    }
}
