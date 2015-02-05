using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlidingCardsDemo.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Default()
        {
            return View("~/Views/Default.cshtml");
        }
    }
}
