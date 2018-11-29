using OgrenciServisTakip.DAL.Repositories.School;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.School
{
    [Authorize]
    public class SchoolController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSchools()
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            return Ok(resporitorySchool.GetAll());
        }

        [HttpPost]
        public void AddBranch(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Add(school);
        }

        [HttpPut]
        public void UpdateBranch(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Update(school);
        }

        [HttpDelete]
        public void DeleteBranch(Model.School.School school)
        {
            ResporitorySchool resporitorySchool = new ResporitorySchool(new DAL.MyContext());
            resporitorySchool.Delete(school);
        }
    }
}
