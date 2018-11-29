using OgrenciServisTakip.DAL.Repositories.Company;
using OgrenciServisTakip.Model.Company;
using System.Web.Http;

namespace OgrenciServisTakip.API.Controllers.Company
{
    [Authorize]
    public class BranchController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetBranches()
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.MyContext());
            return Ok(resporitoryBranch.GetAll());
        }

        [HttpPost]
        public void AddBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.MyContext());
            resporitoryBranch.Add(Branch);
        }

        [HttpPut]
        public void UpdateBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.MyContext());
            resporitoryBranch.Update(Branch);
        }

        [HttpDelete]
        public void DeleteBranch(Branch Branch)
        {
            ResporitoryBranch resporitoryBranch = new ResporitoryBranch(new DAL.MyContext());
            resporitoryBranch.Delete(Branch);
        }
    }
}