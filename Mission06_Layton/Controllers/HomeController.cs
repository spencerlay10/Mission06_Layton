using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Layton.Models;

namespace Mission06_Layton.Controllers
{
    public class HomeController : Controller
    {
        // Create a private context variable
        private EnterMovieContext _context;
        
        public HomeController(EnterMovieContext temp) // Constructor
        {
            _context = temp;
        }

        // Renders index page
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // Renders EnterMovie page
        public IActionResult EnterMovie()
        {
            return View();
        }

        [HttpPost]
        // Renders Confirmation page and allows record to be added to database
        public IActionResult EnterMovie(Form entry)
        {
            
            _context.Movies.Add(entry); // Add record to database
            _context.SaveChanges();

            return View("Confirmation", entry);
        }

        // Renders AboutJoel page
        public IActionResult AboutJoel()
        {
            return View();
        }
    }
}
