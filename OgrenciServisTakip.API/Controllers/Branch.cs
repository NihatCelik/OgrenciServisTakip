using OgrenciServisTakip.DAL.Repositories;
using OgrenciServisTakip.Model.Company;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers
{
    public class BranchController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetBranches()
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.CompanyContext());
            return Ok(resporitoryBranch.GetAll());
        }

        [HttpPost]
        public void AddBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.CompanyContext());
            resporitoryBranch.Add(Branch);
        }

        [HttpPut]
        public void UpdateBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.CompanyContext());
            resporitoryBranch.Update(Branch);
        }

        [HttpDelete]
        public void DeleteBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.CompanyContext());
            resporitoryBranch.Delete(Branch);
        }
    }
}