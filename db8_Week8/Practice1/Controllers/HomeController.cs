using Microsoft.AspNetCore.Mvc;
using Practice1.Models;
using System.Diagnostics;

namespace Practice1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddPet()
        {
            return View(); 
        }

        public IActionResult PetAdded(Animal animal)
        {
            return View(animal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPet([Bind("Species, Name, Color, Gender, Weight, Born")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("PetAdded");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}