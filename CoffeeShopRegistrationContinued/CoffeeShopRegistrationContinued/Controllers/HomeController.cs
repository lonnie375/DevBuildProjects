using CoffeeShopRegistrationContinued.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistrationContinued.Controllers
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

        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }

        public IActionResult Phone()
        {
            return View();
        }

        public IActionResult RegistrationComplete(string firstName, string lastName, string email, string phoneNumber, string password, string confirmPassword, string gender, string state)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.PhoneNumber = phoneNumber;
            ViewBag.Password = password;
            ViewBag.ConfirmPassword = confirmPassword;
            ViewBag.Gender = gender;
            ViewBag.State = state;

            if (password != confirmPassword)
            {
                return Redirect("password");
            }
            else if (phoneNumber.Length != 10)
                {
                return Redirect("phone");
                }
            return View();  
        }

        public IActionResult ViewDataTest()
        {
            ViewData["name"] = "Lonnie Johnson"; ViewData["phoneNumber"] = "3132475894"; ViewData["email"] = "lonniejohnson@rocketmortgage.com";
            return View();
        }

     
        public IActionResult UserData()
        {
            User newUser = new User();
            newUser.Name = "Lonnie";
            newUser.Email = "lonniejohnson@rocketmortgage.com";
            newUser.Phone = "3132475894";
            newUser.Password = "1234";
            return View(newUser);
        }

  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}