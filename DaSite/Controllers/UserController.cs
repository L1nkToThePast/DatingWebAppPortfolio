using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaSite.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Alerts()
        {
            return View();
        }

        public ActionResult Mail()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}