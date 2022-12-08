using Assessment8FOCPotLuckPart2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Assessment8FOCPotLuckPart2.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            List<Dish> dishList = DAL.GetAllDishes();
            return View(dishList);
        }
        public IActionResult AddDish()
        {
            return View(); 
        }
        public IActionResult Dish(Dish dish)
        {
            bool errorfound = false;
            Regex r = new Regex(@"^[0-9]{10}$");

            if (dish.tmname == null || dish.dishname.Length < 1)
            {
                ViewBag.TMMessage = "Please enter the correct name";

                errorfound = true;
            }

            if (dish.phonenumber == null || !r.IsMatch(dish.phonenumber))
            {
                ViewBag.PhoneMessage = "Please enter a 10 digit number";
                errorfound = true;
            }



            if (dish.dishname == null || dish.dishname.Length < 2)
            {
                ViewBag.DishNameMessage = "Your Dish Name must contain at least two characters";
                errorfound = true;
            }

            if (errorfound == true)
            {
                return View("AddDish");
            }
            else
            {
                DAL.InsertDish(dish);
                return View("Dish", dish);
                
            }
            
        }

        public IActionResult EditDish(int id)
        {
            Dish p = DAL.GetADish(id);
            return View(p); 
        }
        public IActionResult SaveChanges(Dish d)
        {
            DAL.UpdateDish(d);
            return Redirect("/dish/index");
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteDish(id);
            return Redirect("/dish");

        }

    }
}
