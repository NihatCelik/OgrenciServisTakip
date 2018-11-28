using OgrenciServisTakip.DAL.Repositories;
using OgrenciServisTakip.Model.Company;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers
{
    [Authorize]
    public class CompanyController : ApiController
    { 
        [HttpGet]
        public IHttpActionResult GetCompanies()
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.CompanyContext());
            return Ok(resporitoryCompany.GetAll());
        }

        [HttpPost]
        public void AddCompany(Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.CompanyContext());
            resporitoryCompany.Add(Company);
        }

        [HttpPut]
        public void UpdateCompany(Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.CompanyContext());
            resporitoryCompany.Update(Company);
        }

        [HttpDelete]
        public void DeleteCompany(Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.CompanyContext());
            resporitoryCompany.Delete(Company);
        }
    }
}