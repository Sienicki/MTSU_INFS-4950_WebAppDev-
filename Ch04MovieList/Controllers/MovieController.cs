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
            ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            var model = new Movie();
            return View("AddEdit", model);
        }
        //Get - Edit Movie
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            //var model = context.Movies.FirstOrDefault(model => model.MovieId == id);
            var model = context.Movies.Find(id);
            return View("AddEdit", model);
        }
        //Post - Save a Movie (for either Add or Edit) in the database table
        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //Is this an Add or Edit/Update
                if(movie.MovieId == 0)
                {
                    context.Movies.Add(movie);
                }
                else
                {
                    context.Movies.Update(movie);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
                return View("AddEdit", movie);
            }
        }
    }
}
