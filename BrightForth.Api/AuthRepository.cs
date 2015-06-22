using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BrightForth.EF;
using BrightForth.Api.Models;
namespace BrightForth.Api
{
    public class AuthRepository:IDisposable
    {
        private erpDBContext _ctx;
        private UserManager<IdentityUser> _userManager;
        public AuthRepository()
        {
            _ctx = new erpDBContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };
            var result = await _userManager.CreateAsync(user,userModel.Password);
            return result;
        }

        

        public async Task<IdentityUser> FindUser(string userName,string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);
            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }
}