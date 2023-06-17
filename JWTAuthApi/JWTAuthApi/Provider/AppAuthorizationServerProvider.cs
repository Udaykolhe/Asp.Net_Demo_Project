using OAuthApi.Repo;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace OAuthApi.Provider
{
    public class AppAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {

       
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            await Task.Yield();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (UserRepo repo = new UserRepo())
            {
                var user = repo.validation(context.UserName, context.Password);

                if (user == null)
                {
                    context.SetError("invalid Grant", "User name or password is incorrect");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));

                foreach (var role in user.Roles.Split(','))
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role.Trim()));
                }
                context.Validated(identity);

            }
            await Task.Yield();
        }
    }
}