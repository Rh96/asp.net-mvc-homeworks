using SEDC.AspNet.Homework.Class04.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class04.App.Models.ViewModels
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
