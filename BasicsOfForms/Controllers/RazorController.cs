using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Razor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Razor(FormCollection form)
        {
            int i = 0;
            return View();
        }
    }
}