using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.Owin.Security.OAuth;
using OgrenciServisTakip.API.Controllers;

namespace OgrenciServisTakip.API
{
    internal class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            UserController uc = new UserController();
            if (uc.GetUsers(context.UserName, context.Password) is OkNegotiatedContentResult<Model.Company.User> result)
            {
                identity.AddClaim(new Claim("username", result.Content.UserID.ToString()));
                context.Validated(identity);
                return;
            }
            context.SetError("Kullanıcı Adı veya Şifre Hatalı");
            return;
        }
    }
}