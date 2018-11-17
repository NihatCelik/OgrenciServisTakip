using OgrenciServisTakip.DAL.Repositories;
using System.Web.Http;
using System.Collections.Generic;
using OgrenciServisTakip.Model.Company;

namespace OgrenciServisTakip.API.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            return resporitoryUser.GetAll();
        }
    }
}