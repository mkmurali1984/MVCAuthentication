using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication.Controllers
{
    [Authorize(Users ="user")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

    }
}