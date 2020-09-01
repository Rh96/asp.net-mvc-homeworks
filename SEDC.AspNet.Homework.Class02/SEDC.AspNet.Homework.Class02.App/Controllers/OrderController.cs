using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Homework.Class02.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    [Route("pizza/order")]
    public class OrderController : Controller
    {
        [HttpGet("create-order")]
        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost("create-order")]
        public IActionResult CreateOrder(Order request)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
