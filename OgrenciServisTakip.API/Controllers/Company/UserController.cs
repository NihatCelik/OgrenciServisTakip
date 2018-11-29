using OgrenciServisTakip.DAL.Repositories.Company;
using OgrenciServisTakip.Model.Company;
using System.Linq;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.Company
{
    [Authorize]
    public class UserController : ApiController
    { 
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.MyContext());
            return Ok(resporitoryUser.GetAll());
        }

        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetUsers(string userName, string password)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.MyContext());
            var result = resporitoryUser.List(u => u.Name == userName && u.Password == password).FirstOrDefault();
            if (result == null) return NotFound();
            else return Ok(result);
        }

        [HttpPost]
        public void AddUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.MyContext());
            resporitoryUser.Add(user);
        }

        [HttpPut]
        public void UpdateUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.MyContext());
            resporitoryUser.Update(user);
        }

        [HttpDelete]
        public void DeleteUser(User user)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.MyContext());
            resporitoryUser.Delete(user);
        }
    }
}