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
    public class employeeController : ApiController
    {
        [Authorize]
        public IHttpActionResult Get()
        {
            return Ok(employees.Employee_list());
        }
    }

        public class employees
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string Age { get; set; }
        public string Start_Date { get; set; }
        public string Salary { get; set; }

        public static List<employees> Employee_list()
        {
            List<employees> emp = new List<employees>
            {
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
                new employees{Name="Tiger Nixon",Position="System Architect",Office="Edinburgh",Age="23",Start_Date="5-jan-15",Salary="$250"},
            };
            return emp;
        }
    }
}
