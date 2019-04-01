using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversion.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0.0);
        }

        [HttpPost]
        public ActionResult Convert(Double inputNum)
        {
            return View(viewName: "Index", model: inputNum*10000000000000000000000000.0);
        }
    }
}