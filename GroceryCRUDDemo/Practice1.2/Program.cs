using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

MySqlConnection Db = new MySqlConnection("Server=127.0.0.1;Database=businessv2;Uid=root;Pwd=QuickenROcketMortgage1111!;");

Employee emp = new Employee()
{
    FirstName = "Charmaine",
    LastName = "Bidelspach",
    Phone = "248-789-9876",
    Email = "cbidelspach@abc.net",
    Department_id = "DEV",
    HireDate = new DateTime(2022, 10, 4)
}; 

Db.Insert(emp); 