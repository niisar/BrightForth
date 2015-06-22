using BrightForth.Api.Models;
using BrightForth.EF;
using BrightForth.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BrightForth.Api.Controllers
{
    public class errorController : ApiController
    {
        public IHttpActionResult post(ErrorLog log)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new erpDBContext())
            {
                ErrLog errlog = new ErrLog();
                errlog.LogError = log.LogError;
                errlog.LogUser = log.LogUser;
                errlog.LogDate = DateTime.Now;

                context.ErrLogs.Add(errlog);
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
