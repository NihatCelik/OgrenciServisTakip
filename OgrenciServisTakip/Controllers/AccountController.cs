using OgrenciServisTakip.Business;
using OgrenciServisTakip.Model.Company;
using System.Net.Http;
using System.Web.Mvc;

namespace OgrenciServisTakip.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(User user)
        {
            HttpResponseMessage response = WebApiSettings.webApiClient.GetAsync("User/GetUser?userName=" + user.UserName + "&password=" + user.Password).Result;
            User u = response.Content.ReadAsAsync<User>().Result;
            if (u == null)
            {
                ViewBag.ErrorLogin = "Hatalı Giriş!";
                return View();
            }
            else
            {
                Session["User"] = u;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult CikisYap()
        {
            Session.Abandon();
            return RedirectToAction("GirisYap", "Account");
        }
    }
}