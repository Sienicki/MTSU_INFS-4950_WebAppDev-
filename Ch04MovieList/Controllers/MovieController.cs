using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ch04MovieList.Models;

namespace Ch04MovieList.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context { get; set; }
        public MovieController(MovieContext ctx)
        {
            context = ctx;
        }
        //Get - Add new Movie
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            var model = new Movie();
            return View("AddEdit", model);
        }
        //Get - Edit Movie
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var model = context.Movies.FirstOrDefault(model => model.MovieId == id);
            return View("AddEdit", model);
        }
    }
}
