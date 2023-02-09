using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class Home : Controller
    {
        private readonly ILogger<Home> _logger;
        private MoviesContext _moviesContext { get; set; }

        public Home(ILogger<Home> logger, MoviesContext moviesContext)
        {
            _logger = logger;
            _moviesContext = moviesContext;
        }

        public IActionResult Index()
        {
            var movies = _moviesContext.addMovies.ToList();
            ViewBag.Categories = _moviesContext.movieCategories.ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            //var categories = _moviesContext.movieCategories.ToList();
            ViewBag.Categories = _moviesContext.movieCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovie Movie)
        {
            if (ModelState.IsValid)
            {
                _moviesContext.Add(Movie);
                _moviesContext.SaveChanges();
                return RedirectToAction("AddMovie");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult UpdateMovie(int movieID)
        {
            var movie = _moviesContext.addMovies.Single(x => x.Id == movieID);
            ViewBag.Categories = _moviesContext.movieCategories.ToList();
            
            return View(movie);
        }

        [HttpPost]
        public IActionResult UpdateMovie(AddMovie Movie)
        {
            _moviesContext.Update(Movie);
            _moviesContext.SaveChanges();

            var movies = _moviesContext.addMovies.ToList();

            ViewBag.Categories = _moviesContext.movieCategories.ToList();

            return View("Index", movies);
        }

        public IActionResult DeleteMovie(int movieID)
        {
            var movie = _moviesContext.addMovies.Single(x => x.Id == movieID);
            
            _moviesContext.Remove(movie);
            _moviesContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
