using OgrenciServisTakip.DAL.Repositories;
using OgrenciServisTakip.Model.Company;
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

        [HttpPost]
        public void AddUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            resporitoryUser.Add(user);
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            resporitoryUser.Update(user);
        }

        [HttpDelete]
        public void DeleteUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            resporitoryUser.Delete(user);
        }
    }
}