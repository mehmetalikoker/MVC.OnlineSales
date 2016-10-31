﻿using OnlineSales.Admin.ViewModel;
using OnlineSales.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineSales.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pagelModel = new HomePageModel();
            return View(pagelModel);
        }

    }
}