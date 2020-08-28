using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetMovieByDateTime(DateTime? releaseDate)
        {
            var testMovie = new
            {
                MovieName = "TestMovie",
                ReleaseDate = releaseDate
            };

            return Json(testMovie);
        }

        public IActionResult GetMovieByAvailable(bool isAvailable)
        {
            var testMovie = new
            {
                MovieName = "TestMovie2",
                IsAvailable = isAvailable
            };

            return Json(testMovie);
        }
    }
}
