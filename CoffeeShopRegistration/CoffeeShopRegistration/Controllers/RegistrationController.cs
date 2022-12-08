using CoffeeShopRegistration.Data;
using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public  IActionResult Index()
        {
            return View();
        }

        //Get:Create
        //Returns the view for the registration form 
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Summary(Registration user)
        {
         
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration([Bind("Id, FirstName, LastName, Email, Password, ConfirmPassword")] Registration register)
        {
            if (ModelState.IsValid)
            {
                _context.Add(register);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Summary), register);
            }
            return View();
        }
    }
}
