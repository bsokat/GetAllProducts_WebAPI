﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetAllProducts_WebAPI.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult AllProducts()
        {
            return View();
        }
        public ActionResult GetProduct()
        {
            return View();
        }
        public ActionResult CreateProduct()
        {
            return View();
        }
    }
}