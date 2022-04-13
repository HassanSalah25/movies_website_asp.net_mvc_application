using Microsoft.AspNetCore.Mvc;
using movies_website_asp.net_mvc_application.Data;
using movies_website_asp.net_mvc_application.Models;

namespace movies_website_asp.net_mvc_application.Controllers
{
    public class UsersController : Controller
    {
        public readonly AppDBContext _context;
        public UsersController(AppDBContext context) => _context = context;
        public IActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users user)
        {

            var newUser = _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

    }
}
