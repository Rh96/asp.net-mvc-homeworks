﻿using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Homework.Class04.App.InMemoryDatabase;
using SEDC.AspNet.Homework.Class04.App.Models.Domain;
using SEDC.AspNet.Homework.Class04.App.Models.Enums;
using SEDC.AspNet.Homework.Class04.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class04.App.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("Products")]
       public IActionResult Index()
        {
            ViewBag.Error = TempData["Info"];
            
            var listOfProductsVM = new List<ProductVM>();
            foreach (var product in Database.Products)
            {
                var productVM = new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Category = product.Category
                };

                listOfProductsVM.Add(productVM);
            }

            ProductListVM productListVM = new ProductListVM()
            {
                Products = listOfProductsVM
            };

            ViewBag.Title = "Welcome to our Store Page";

            return View("Products", productListVM);
        }

        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductVM createProduct)
        {

            if (!ModelState.IsValid)
            {
                return View(createProduct);
            }

            var product = new Product()
            {
                Id = Database.Products.Count + 1,
                Name = createProduct.Name,
                Description = createProduct.Description,
                Price = createProduct.Price,
                Category = createProduct.Category
            };

            Database.Products.Add(product);
            return View("ProductComplete");
        }

        [HttpGet("products/{id:int}")]
        public IActionResult ProductDetails(int id)
        {
            var products = Database.Products.FirstOrDefault(p => p.Id == id);

            if (products == null)
            {
                TempData["Info"] = $"The product with id: {id} does not exist!";
                return RedirectToAction("Index");
            }

            var productVM = new ProductVM()
            {
                Id = products.Id,
                Name = products.Name,
                Description = products.Description,
                Price = products.Price,
                Category = products.Category
            };

            return View("Details", productVM);
        }
    }
}
