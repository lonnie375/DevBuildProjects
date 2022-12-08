using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper;
namespace BusinessV2Demo.Models
{
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=businessv2;Uid=root;Pwd=QuickenROcketMortgage1111!;");

        //CRUD Operations for Department 

        //Read All
        public static List<Department> GetAllDepartments()
        {
            return DB.GetAll<Department>().ToList();
        }

        //Read One 
        public static Department GetDepartment(string id)
        {
            return DB.Get<Department>(id);
        }

        //Create 
        public static Department AddDepartment(Department dept)
        {
            DB.Insert<Department>(dept);
            return dept;
        }

        //Edit 
        public static void UpdateDepartment(Department dept)
        {
            DB.Update<Department>(dept);

        }

        //Delete 
        public static void DeleteEmployee(string id)
        {
            Department dept = new Department();
            dept.id = id;
            DB.Delete<Department>(dept);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        //CRUD Operations for Employee 

        public static List<Employee> GetAllEmployees()
        {
            return DB.GetAll<Employee>().ToList();
        }

        //Read One 
        public static Employee GetEmployee(int id)
        {
            return DB.Get<Employee>(id);
        }

        //Create 
        public static Employee AddEmployee(Employee empl)
        {
            DB.Insert<Employee>(empl);
            return empl;
        }

        //Edit 
        public static void UpdateEmployee(Employee empl)
        {
            DB.Update<Employee>(empl);

        }

        //Delete 
        public static void DeleteEmployee(int id)
        {
            Employee empl = new Employee();
            empl.id = id;
            DB.Delete<Employee>(empl);
        }
    }
}
