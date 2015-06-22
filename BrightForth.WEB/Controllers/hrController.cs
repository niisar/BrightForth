using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrightForth.Web.Controllers
{
    public class hrController : Controller
    {
        // GET: hr 

        public ActionResult employees()
        {
            return View();
        }
        public ActionResult employeesList()
        {
            return View();
        }

        public ActionResult employeesGrid()
        {
            return View();
        }

        public ActionResult addEmployee()
        {
            return View();
        }


        
    }
}