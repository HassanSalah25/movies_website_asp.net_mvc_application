using Microsoft.AspNetCore.Mvc;
using movies_website_asp.net_mvc_application.Models;
using movies_website_asp.net_mvc_application.Data;

namespace movies_website_asp.net_mvc_application.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDBContext _context;

        public MoviesController(AppDBContext context) => _context = context;

        public  IActionResult Index()
        {
            var allMovies = _context.Movies.ToList();
            return View(allMovies);
        }
    }
}
