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
        [Required()]
        [MinLength(6, ErrorMessage = "The field Name must be a string with a minimum length of '6' characters")]
        public string Name { get; set; }
        [Required]
        [Range(50,100000)]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
