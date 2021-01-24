using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvcExample.Library.Controllers
{
    public class JavascriptTriggerController : Controller
    {
        // GET: JavascriptTrigger
        public ActionResult TriggerAction(int? id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}