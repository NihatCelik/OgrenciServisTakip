using OgrenciServisTakip.DAL.Repositories.Company;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.Company
{ 
    public class CompanyController : ApiController
    { 
        [HttpGet]
        public IHttpActionResult GetCompanies()
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.MyContext());
            return Ok(resporitoryCompany.GetAll());
        }

        [HttpPost]
        public void AddCompany(Model.Company.Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.MyContext());
            resporitoryCompany.Add(Company);
        }

        [HttpPut]
        public void UpdateCompany(Model.Company.Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.MyContext());
            resporitoryCompany.Update(Company);
        }

        [HttpDelete]
        public void DeleteCompany(Model.Company.Company Company)
        {
            ResporitoryCompany resporitoryCompany = new ResporitoryCompany(new DAL.MyContext());
            resporitoryCompany.Delete(Company);
        }
    }
}