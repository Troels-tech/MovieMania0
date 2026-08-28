using Microsoft.AspNetCore.Mvc;
using MovieMania01;
using MovieMania01.Persistence;
using MovieMania01.Models;

namespace MovieMania01.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = MovieRepository.GetAll();

            return View(movies);
        }
    }
}
