using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace OgrenciServisTakip.DAL.Repositories.School
{
    public class ResporitorySchool : Repository<Model.School.School>
    {
        public ResporitorySchool(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Model.School.School> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<Model.School.School> List(Expression<Func<Model.School.School, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override Model.School.School GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override void Add(Model.School.School entity)
        {
            base.Add(entity);
        }

        public override void Update(Model.School.School entity)
        {
            base.Update(entity);
        }

        public override void Delete(Model.School.School entity)
        {
            base.Delete(entity);
        }
    }
}
