using GroceryCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryCRUDDemo.Controllers
{
    public class ProductController : Controller
    {
        //List all products
        public IActionResult Index()
        {
            // Instead of saving the product list into a variable 
            return View(DAL.GetAllProducts());
        }

        //Display detail for a single product 
        public IActionResult Detail(int id)
        {
            return View(DAL.GetProduct(id)); 
        }

        //Add product 
        //  1. A route to send the form to the browser 
        // 2. A route the browzwer calls when the form is submitted 
        public IActionResult AddForm()
        {
            List<Category> cats = DAL.GetAllCategories();   
            return View(cats);
        }
       
        public IActionResult Add(Product prod)
        {
            // Validation: if a field is blank, set a message for it 
            // and send them back to the form 
            // Aleays validate on both sides 
            //   (1) the browser (client) side 
            //   (2) the server side 
            bool isValid = true;    
            if (prod.Name == null)
            {
                ViewBag.NameMessage = "Name is required."; 
                isValid = false;
            }
            if (prod.Description == null)
            {
                ViewBag.DescMessage = "Description is required"; 
                isValid = false;
            }
            if (prod.Price <= 0)
            {
                ViewBag.PriceMessage = "Price must be greater than 0"; 
                isValid = false;
            }
            if (isValid)
            {
                DAL.InsertProduct(prod);
                return Redirect("/product");
            }
            else
            {
                List<Category> cats = DAL.GetAllCategories();
                ViewBag.Name = prod.Name; 
                ViewBag.Description = prod.Description;
                ViewBag.Price = prod.Price;
                ViewBag.Inventory = prod.Inventory; 
                return View("AddForm", cats); 
            }


        }

        //Delete product 
        //This one won't returna  view. Instead it will redirect 
        //back to the index/product 
        public IActionResult Delete(int id)
        {
            DAL.DeleteProduct(id);
            return Redirect("/product");
        }

        // Edit a product
        //  1. A route to send the form (propulated) to the browswer 
        // 2. A route that does the update and redirects to index 

        public IActionResult EditForm(int id)
        {
            ViewData["categories"] = DAL.GetAllCategories(); 
            return View(DAL.GetProduct(id));
        }

        public IActionResult SaveChanges(Product prod)
        {
            DAL.UpdateProduct(prod);
            return Redirect("/product"); 
        }
    }
}
