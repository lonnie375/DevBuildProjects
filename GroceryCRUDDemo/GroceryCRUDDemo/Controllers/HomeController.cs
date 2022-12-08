using GroceryCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroceryCRUDDemo.Controllers
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
            List<Category> cats = DAL.GetAllCategories(); 

            //To make sure we have the right number of categories
            ViewBag.count = cats.Count; 
            return View(); 
        }

        public IActionResult Privacy()
        {
            Product prod = new Product();
            prod.Name = "Aaa";
            prod.Description = "Aaa test product";
            prod.Price = 1.50m;
            prod.Inventory = 10;
            prod.Category = "FRUIT"; 
            DAL.InsertProduct(prod);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}