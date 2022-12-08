using Dapper.Contrib.Extensions;
using Daperconsole;
using MySql.Data.MySqlClient;
using Dapper;

var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=QuickenROcketMortgage1111!");

//List<Employee> emps = db.GetAll<Employee>().ToList(); //uses "Table to identify the class/table we are using. This is going to create a list of employees 

////Should print all of the items in our database 
//foreach(Employee emp in emps)
//{
//    Console.WriteLine(emp);
//}

//////Lets add a new employee 
//////Leave out the ID as the database is going to add this in for us 

////Employee e1 = new Employee() { firstname = "Jeff", lastname = "COgswell", phone = "817-111-2222", email = "jf@gmail.com", department = "IT" }; 
////db.Insert(e1);

//////Delete items from the database 
////db.Delete(new Employee() { id = 28});

////Read from the database
//Console.WriteLine("Lets just read a single one, by ID. We'll do id 5");
//Employee e2 = db.Get<Employee>(5);
//Console.WriteLine(e2);

////Update 
//e2.firstname = "Emilie";
////db.Update<Employee>(e2);

//Console.WriteLine();
//Console.WriteLine("Let's get all employees who work in the IT department");
//List<Employee> emps2 = db.Query<Employee>("select * from employee where department = 'IT'").ToList(); 
//foreach(Employee emp in emps2)
//{
//    Console.WriteLine(emp);
//}

////Department 'Acct'
//List<Employee> emps3 = db.Query<Employee>("select * from employee where department = 'Acct'").ToList(); 
//foreach(Employee employee in emps3)
//{
//    Console.WriteLine(employee);
//}

//Lets work with the Department table 
List<Department> dep1 = db.GetAll<Department>().ToList(); 

foreach (Department dep in dep1)
{
    Console.WriteLine(dep);
}

//Print all departments that are in Ferndale 
List<Department> dep2= db.Query<Department>("select * from department where location = 'Grand Rapids'").ToList();
foreach(Department dep in dep2)
{
    Console.WriteLine(String.Join(",", dep));
}

//Add new item 
Department newDepartment = new Department() { id = "MB", name = "Mortgage Banking", location = "Detroit" }; 
db.Insert(newDepartment);

