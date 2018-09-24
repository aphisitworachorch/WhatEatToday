using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhatEatToday.Models;

namespace WhatEatToday.Controllers
{
    public class ShopController : Controller
    {
        ShopEntities sh = new ShopEntities();

        // GET: Shop
        public ActionResult Index()
        {
            ViewBag.listShop = sh.Shop.ToList();
            return View();
        }
    }
}