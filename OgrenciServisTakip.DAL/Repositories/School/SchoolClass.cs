using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions; 
using OgrenciServisTakip.Model.School;

namespace OgrenciServisTakip.DAL.Repositories.School
{
    public class ResporitorySchoolClass : Repository<SchoolClass>
    {
        public ResporitorySchoolClass(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<SchoolClass> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<SchoolClass> List(Expression<Func<SchoolClass, bool>> predicate)
        {
            return base.List(predicate);
        }

        public override SchoolClass GetByID(int id)
        {
            return base.GetByID(id);
        }

        public override void Add(SchoolClass entity)
        {
            base.Add(entity);
        }

        public override void Update(SchoolClass entity)
        {
            base.Update(entity);
        }

        public override void Delete(SchoolClass entity)
        {
            base.Delete(entity);
        }  
    }
}
