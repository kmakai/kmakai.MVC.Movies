using kmakai.MVC.Movies.DataAccess;
using kmakai.MVC.Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kmakai.MVC.Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            var books = _context.Books.ToList();
            ViewData["Movies"] = movies;
            ViewData["Books"] = books;

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