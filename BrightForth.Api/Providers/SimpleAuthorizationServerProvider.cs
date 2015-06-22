using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using BrightForth.EF;
using BrightForth.EF.Entities;

namespace BrightForth.Api.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

                var manager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new erpDBContext()));

                using (AuthRepository _repo = new AuthRepository())
                {
                    IdentityUser user = await _repo.FindUser(context.UserName, context.Password);
                    if (user == null)
                    {
                        context.SetError("invalid_grant", "The user name or password is incorrect.");
                        using (var db = new erpDBContext())
                        {
                            ErrLog errlog = new ErrLog();
                            errlog.LogError = "The user name or password is incorrect.";
                            errlog.LogUser = context.UserName;
                            errlog.LogDate = DateTime.Now;

                            db.ErrLogs.Add(errlog);
                            db.SaveChanges();
                        }
                        return;
                    }
                }
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim("sub", context.UserName));
                context.Validated(identity);
          

        }
    }
}