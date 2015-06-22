using BrightForth.EF.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightForth.EF
{
    public class erpDBContext:IdentityDbContext<IdentityUser>
    {
        public erpDBContext():base("conStr1")
        {

        }

        public DbSet<ErrLog> ErrLogs { get; set; }
    }
}
