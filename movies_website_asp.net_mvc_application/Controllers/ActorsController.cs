using Microsoft.AspNetCore.Mvc;
using movies_website_asp.net_mvc_application.Data;

namespace movies_website_asp.net_mvc_application.Controllers
{
    public class ActorsController : Controller
    {
        public readonly AppDBContext _context;
        public ActorsController(AppDBContext context) => _context = context;
        public IActionResult Index()
        {
            var AllActors = _context.Actors.ToList();
            return View(AllActors);
        }
    }
}
