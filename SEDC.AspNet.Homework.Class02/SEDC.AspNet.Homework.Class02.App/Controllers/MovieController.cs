using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Homework.Class02.App.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        [HttpGet("get-movies/{releasedate:datetime}")]
        public IActionResult GetMovieByDateTime(DateTime? releaseDate)
        {
            var testMovie = new
            {
                MovieName = "TestMovie",
                ReleaseDate = releaseDate
            };

            return Json(testMovie);
        }

        [HttpGet("get-available/{isavailable:bool}")]
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
