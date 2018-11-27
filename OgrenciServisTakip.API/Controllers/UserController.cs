using OgrenciServisTakip.DAL.Repositories;
using OgrenciServisTakip.Model.Company;
using System;
using System.Linq;
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

        [HttpGet]
        public IHttpActionResult GetUsers(string userName, string password)
        {
            ResporitoryUser resporitoryUser = new ResporitoryUser(new DAL.CompanyContext());
            var result = resporitoryUser.List(u => u.Name == userName && u.Password == password).FirstOrDefault();
            if (result == null) return NotFound();
            else return Ok(result);
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