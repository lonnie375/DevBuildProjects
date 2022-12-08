using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

using BusinessPortal.Models;

namespace BusinessPortal.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=QuickenROcketMortgage1111!");
            IEnumerable<Department> depts = db.GetAll<Department>(); 
            //List all of the departments 
            //GET all 
            return View(depts);
        }

        //view a single department and its details based on its id 
        public IActionResult Detail(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=QuickenROcketMortgage1111!");

            Department dep = db.Get<Department>(id);

            //Lets get a list of people who work there 
            List<Employee> emps = db.Query<Employee>($"select * from employee where department = '{id}'").ToList();

            //Using View Data to store the list of employees and bring it to the view since we can't have two models in the view
            ViewData["employees"] = emps; 

            return View(dep);
           // return Content(id); This was done to test to see if the web page was receiving our method. 

        }

        //view that presents a form for adding a new department (creating an instance) and takes the users input 


        //An action that responsds to the form for adding a new department 
        public IActionResult AddForm()
        {
               return View();
        }

        //Delete a department based on the users input => ID
        public IActionResult Delete(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=QuickenROcketMortgage1111!");
            
            Department dept = new Department() { id = id };
            db.Delete(dept);
            //Return redirect will put is back on the page we were on. 
            //The item will be removed 
            return Redirect("/department/index");
        }

        //Edit a department based on the users input => ID
    }
}
