using kmakai.MVC.Movies.DataAccess;
using kmakai.MVC.Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace kmakai.MVC.Movies.Controllers;

public class MovieController : Controller
{
    private readonly AppDbContext _context;

    public MovieController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var movies = _context.Movies.ToList();

        return View(movies);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit(int id)
    {
        return View();
    }
}
