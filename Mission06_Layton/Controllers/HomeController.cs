using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Layton.Models;

namespace Mission06_Layton.Controllers
{
    public class HomeController : Controller
    {
        private EnterMovieContext _context;
        public HomeController(EnterMovieContext temp) // Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Form entry)
        {
            
            _context.Movies.Add(entry); // Add record to database
            _context.SaveChanges();

            return View("Confirmation", entry);
        }
        public IActionResult AboutJoel()
        {
            return View();
        }
    }
}
