using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskFour.Web.Controllers
{
    public class commonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error_404()
        {
            return View();
        }
        public ActionResult Error_505()
        {
            return View();
        }
        public ActionResult Forgot_Password()
        {
            return View();
        }
        public ActionResult Lock_Screen()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
    }
}