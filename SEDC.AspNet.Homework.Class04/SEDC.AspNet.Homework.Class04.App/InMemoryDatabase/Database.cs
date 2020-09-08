using SEDC.AspNet.Homework.Class04.App.Models.Domain;
using SEDC.AspNet.Homework.Class04.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class04.App.InMemoryDatabase
{
    public static class Database
    {
        public static List<Product> Products;

        static Database()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Laptop Lenovo",
                    Description = "Gaming-Laptop",
                    Price = 52000,
                    Category = Category.Electronics
                },
                new Product()
                {
                    Id = 2,
                    Name = "Notebook Dell",
                    Description = "Business-Laptop",
                    Price = 23500,
                    Category = Category.Electronics
                },
                new Product()
                {
                    Id = 3,
                    Name = "Huawei P30 Lite",
                    Description = "Smartphone",
                    Price = 12300,
                    Category = Category.Electronics
                },
                new Product()
                {
                    Id = 4,
                    Name = "Samsung Galaxy S10 Lite",
                    Description = "Smartphone",
                    Price = 32500,
                    Category = Category.Electronics
                },

                new Product()
                {
                    Id = 5,
                    Name = "HTML & CSS: Design and Build Web Sites",
                    Description = "A full-color introduction to the basics of HTML and CSS",
                    Price = 500,
                    Category = Category.Books
                },
                new Product()
                {
                    Id = 6,
                    Name = "Thinking in Java",
                    Description = "Thinking in Java is a book about the Java programming language, written by Bruce Eckel and first published in 1998",
                    Price = 700,
                    Category = Category.Books
                },
            };
        }
    }
}
