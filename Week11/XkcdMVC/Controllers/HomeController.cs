using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using XkcdMVC.Models;

namespace XkcdMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
     
        public async Task<IActionResult> Index(string comicNum)
        {
            HttpClient web = new HttpClient(); //Opens the connection 
            web.BaseAddress = new Uri("https://xkcd.com/"); //Connects us to the website 
            var connection = await web.GetAsync($"{comicNum}/info.0.json"); //Gets information
            try
            {
                Comic com = await connection.Content.ReadAsAsync<Comic>(); //Returns information 
                return View(com);
            }
            catch (Exception ex)
            {
               return View();
            }

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