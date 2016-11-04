using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : Controller
    {
        // GET: Basics/Index
        public ActionResult Index()
        {
            return View();
        }

        // POST FROM: Basics/Index
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int i = 0;
            return View();
        }

        //GET: Basics/Razor
        public ActionResult Razor()
        {
            return View();
        }

        //POST FROM: Basics/Razor
        [HttpPost]
        public ActionResult Razor(FormCollection form)
        {
            int i = 0;
            return View();
        }
    }
}