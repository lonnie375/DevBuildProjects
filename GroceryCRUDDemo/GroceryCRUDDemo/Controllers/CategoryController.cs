
using Dapper;
using GroceryCRUDDemo.Models; 
using Microsoft.AspNetCore.Mvc;

namespace GroceryCRUDDemo.Controllers
{
    public class CategoryController : Controller
    {
        
        public IActionResult Index()
        {
            List<Category> cats = DAL.GetAllCategories(); 
            return View(cats);
        }

        public IActionResult AddForm()
        {
            return View();  
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
        public IActionResult Add(Category cat)
        {
            DAL.InsertCategory(cat);
            return Redirect("/category");
        }

        // FOr details page, we have to decide how to write our code. 
        // We have some choices for the URL: ?=id https://localhost.7034/category/deail?id=FRUIT or /name of the item https://localhost.7034/category/detail/FRUIT
       
        public IActionResult Detail(string id)
        {
            Category cat = DAL.GetOneCategory(id); 
            return View(cat);
        }

        public IActionResult ConfirmDelete(string id)
        {
            Category cat = DAL.GetOneCategory(id);
            //ViewData["categoryid"] = id; Don't need this line anymore 
            return View(cat);
        }

        public IActionResult Delete(string id)
        {
            DAL.DeleteCategory(id);
            return Redirect("/category"); 
        }

        public IActionResult EditForm(string id)
        {
        Category cat = DAL.GetOneCategory(id);
            return View(cat);
        }

        public IActionResult SaveChanges(Category cat)
        {
            DAL.UpdateCategory(cat);
            return Redirect("/category"); 
        }


    }
}
