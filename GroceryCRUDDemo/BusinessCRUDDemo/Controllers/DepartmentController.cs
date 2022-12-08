using BusinessCRUDDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessCRUDDemo.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> dept = DAL.GetAllDepartments();
            return View(dept);
        }

        public IActionResult AddForm()
        {
            return View(); 
        }

        public IActionResult Add(Department dept)
        {
            DAL.AddDepartment(dept);
            return Redirect("/department"); 
        }

        public IActionResult Detail(string id)
        {
            Department dept = DAL.GetDepartment(id);
            return View(dept); 
        }

        public IActionResult EditForm(string id)
        {
            Department dept = DAL.GetDepartment(id);
            return View(dept); 
        }

        public IActionResult SaveForm(Department dept)
        {
            DAL.UpdateDepartment(dept);
            return Redirect("/department"); 
        }

        public IActionResult Delete(string id)
        {
            DAL.DeleteEmployee(id);
            return Redirect("/department"); 
        }
    }
}
