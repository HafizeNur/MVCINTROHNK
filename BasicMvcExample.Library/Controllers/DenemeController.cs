﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvcExample.Library.Controllerss
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {
            return View();
        }
    }
}