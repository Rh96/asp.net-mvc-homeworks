using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet("get-product/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var testProduct = new
            {
                Name = "Test Product 1",
                Id = id
            };

            return Json(testProduct);
        }

        [HttpGet("get-product/{id:alpha}")]
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
