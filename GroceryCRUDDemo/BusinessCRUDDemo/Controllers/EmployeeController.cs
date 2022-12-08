using BusinessCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessCRUDDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> empl = DAL.GetAllEmployees();
            return View(empl);
        }

        public IActionResult AddForm()
        {
            return View(); 
        }

        public IActionResult Add(Employee empl)
        {
            DAL.AddEmployee(empl);
            return Redirect("/employee"); 
        }

        public IActionResult Detail(int id)
        {
            Employee emp = DAL.GetEmployee(id);
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteEmployee(id);
            return Redirect("/employee"); 
        }

        public IActionResult EditForm(int id)
        {
            Employee empl = DAL.GetEmployee(id);
            return View(empl);
        }

        public IActionResult SaveChanges(Employee empl)
        {
            DAL.UpdateEmployee(empl);
            return Redirect("/employee");
        }



    }
}
