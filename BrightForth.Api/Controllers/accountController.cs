using BrightForth.Api.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BrightForth.Api.Controllers
{
    [RoutePrefix("api/account")]
    public class accountController : ApiController
    {
        private AuthRepository _repo = null;
        private accountController()
        {
            _repo = new AuthRepository();
        }

        [AllowAnonymous]
        [Route("register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);
            IHttpActionResult errorResult = GetErrorResult(result);
            if(errorResult != null)
            {
                return errorResult;
            }
            return Ok();
        }
        

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if(result == null)
            {
                return InternalServerError();
            }

            if(!result.Succeeded)
            {
                if(result.Errors != null)
                {
                    foreach(string error in result.Errors)
                    {
                        ModelState.AddModelError("",error);
                    }
                }
                if(ModelState.IsValid)
                {
                    return BadRequest();
                }
                return BadRequest(ModelState);
            }
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _repo.Dispose();
                base.Dispose(disposing);
            }
        }
    }
}
