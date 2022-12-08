using InstrumentsDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentsDemo.Controllers
{
    public class InstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowForm()
        {
            return View();
        }



        public IActionResult Add(Instrument inst)
        {
            bool errorfound = false;
            //Validation
            if (inst.Year > DateTime.Now.Year)
            {
                ViewBag.YearMessage = "Please enter the correct year.";
                errorfound = true;
            }
            if (inst.Price <= 0)
            {
                ViewBag.PriceMessage = "Price must be greater than 0";
                errorfound = true;
            }

            if (errorfound == true)
            {
                return View("ShowForm");
            }
            else
            {
                return View(inst);
            }

            return View(inst);

        }
    }
}
