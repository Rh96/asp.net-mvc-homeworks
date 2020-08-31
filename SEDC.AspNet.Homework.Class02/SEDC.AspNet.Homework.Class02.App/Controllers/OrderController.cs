using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Homework.Class02.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Order request)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
