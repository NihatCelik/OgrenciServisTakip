using OgrenciServisTakip.DAL.Repositories.School;
using OgrenciServisTakip.Model.School;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.School
{
    [Authorize]
    public class SchoolClassController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSchoolClasses()
        {
            ResporitorySchoolClass resporitorySchoolClass = new ResporitorySchoolClass(new DAL.MyContext());
            return Ok(resporitorySchoolClass.GetAll());
        }

        [HttpPost]
        public void AddSchoolClass(SchoolClass schoolClass)
        {
            ResporitorySchoolClass resporitorySchoolClass = new ResporitorySchoolClass(new DAL.MyContext());
            resporitorySchoolClass.Add(schoolClass);
        }

        [HttpPut]
        public void UpdateSchoolClass(SchoolClass schoolClass)
        {
            ResporitorySchoolClass resporitorySchoolClass = new ResporitorySchoolClass(new DAL.MyContext());
            resporitorySchoolClass.Update(schoolClass);
        }

        [HttpDelete]
        public void DeleteSchoolClass(SchoolClass schoolClass)
        {
            ResporitorySchoolClass resporitorySchoolClass = new ResporitorySchoolClass(new DAL.MyContext());
            resporitorySchoolClass.Delete(schoolClass);
        }
    }
}
