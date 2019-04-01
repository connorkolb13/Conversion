using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversion.Controllers
{
    public class JacobController : Controller
    {
        // GET: Jacob
        public ActionResult Jacob()
        {
            return View(viewName: "Jacob", model: 0.0);
        }

        [HttpPost]
        public ActionResult ConvertNum(double inputNum)
        {
            return View(viewName: "Jacob", model: Convert(inputNum));
        }

        public double Convert(double inputNum)
        {
            return inputNum * 0.4375;
        }
    }
}