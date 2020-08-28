using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProductById(int id)
        {
            var testProduct = new
            {
                Name = "Test Product 1",
                Id = id
            };

            return Json(testProduct);
        }

        public IActionResult GetProductByName(string id)
        {
            var testProduct = new
            {
                Name = "Test Product 2",
                Id = id
            };

            return Json(testProduct);
        }
    }
}
