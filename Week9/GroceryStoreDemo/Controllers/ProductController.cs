using Microsoft.AspNetCore.Mvc;
using Dapper.Contrib.Extensions;
using GroceryStoreDemo.Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace GroceryStoreDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=QuickenROcketMortgage1111!");
            List<Product> prods = db.GetAll<Product>().ToList(); 
            return View(prods);

        }

    }
}
