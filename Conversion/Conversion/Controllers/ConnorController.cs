using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversion.Controllers
{
    public class ConnorController : Controller
    {
        // GET: Connor
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "Please enter a value for inches.");
        }

        [HttpPost]
        public ActionResult SayCent(string input)
        {
            double cm = this.convertIn(input);
            return View(viewName: "Index", model: input + "in = " + cm + "cm");
        }

        public Double convertIn(String input)
        {
            double inches = Double.Parse(input);
            double cm = inches * 2.54;
            return cm;
        }


    }
}