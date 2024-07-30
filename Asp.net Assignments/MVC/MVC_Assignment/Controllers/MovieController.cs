using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;
namespace MVC_Assignment.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository;
        public MovieController()
        {
            movieRepository = new MovieRepository();
        }
        public IActionResult Index()
        {
            var products = movieRepository.GetMovies();
            return View(products);
        }
        public IActionResult Details(string title)
        {
            var product = movieRepository.GetMovieByName(title);
            return View(product);
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            movieRepository.Add(movie);
            return RedirectToAction("Index");
        }
    }
}

