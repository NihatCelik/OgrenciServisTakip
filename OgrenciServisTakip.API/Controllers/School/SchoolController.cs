using OgrenciServisTakip.DAL.Repositories.School;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.School
{ 
    public class SchoolController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSchools()
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            return Ok(resporitorySchool.GetAll());
        }

        [HttpPost]
        public void AddSchool(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Add(school);
        }

        [HttpPut]
        public void UpdateSchool(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Update(school);
        }

        [HttpDelete]
        public void DeleteSchool(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Delete(school);
        }
    }
}
