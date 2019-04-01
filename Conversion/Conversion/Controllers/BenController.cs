using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversion.Controllers
{
    public class BenController : Controller
    {
        // GET: Ben
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All starts here.");
        }
        public ActionResult Ben()
        {
            return View(viewName: "Ben", model: 0.0);
        }
        [HttpPost]
        public ActionResult toFathoms(double inputNumberFields)
        {
            return View(viewName: "Ben", model: inputNumberFields * 50.0);
        }
       
    }
}