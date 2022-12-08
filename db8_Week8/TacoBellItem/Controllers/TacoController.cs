using Microsoft.AspNetCore.Mvc;
using TacoBellItem.Models;

namespace TacoBellItem.Controllers
{
    public class TacoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderForm()
        {
            return View();
        }

        public IActionResult Receipt(TacoOrdering taco)
        {

            if (taco.Name == null)
            {
                return View("NameError");
            }

            if(taco.Price <= 0)
            {
                return View("PriceError"); 
            }

            return View(taco);
        }

    }
}
