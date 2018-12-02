using OgrenciServisTakip.Model.Company;
using System.Web.Mvc;

namespace OgrenciServisTakip.Controllers
{
    public class AccountController : Controller
    { 
        public ActionResult GirisYap(User user)
        {
            return View();
        }
    }
}