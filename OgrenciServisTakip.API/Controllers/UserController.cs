using OgrenciServisTakip.DAL.Repositories;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            return Ok(resporitoryUser.GetAll());
        }
    }
}