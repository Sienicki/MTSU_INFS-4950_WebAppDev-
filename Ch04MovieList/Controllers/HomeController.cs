using Ch04MovieList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Ch04MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            //Generate a query expression and execute 
            var movies = context.Movies
                .Include(m => m.Genre)
                //.Where(m=> m.Year > 1970)
                //.Where(m => m.Rating > 3)
                .OrderBy(m => m.Name)
                .ToList();

            return View(movies);
        }

       
        
    }
}
