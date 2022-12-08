using Microsoft.AspNetCore.Mvc;
using NASAAPIFUN.Models;
using System.Diagnostics;

namespace NASAAPIFUN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> DisplayList(string roverName, string earth_date)
        {
            HttpClient _web = new HttpClient(); //Opens the connection 
            _web.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/");
            var connection = await _web.GetAsync($"v1/rovers/{roverName}/photos?earth_date={earth_date}&api_key=Rvlc9pRqISHsBiywq1F8GhEHghUN9ddUE6f2dMd1");
            RoverResponse resp = await connection.Content.ReadAsAsync<RoverResponse>();
            return View(resp);
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