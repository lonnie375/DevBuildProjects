using Dapper.Contrib.Extensions;
using GroceryStore;
using MySql.Data.MySqlClient;
using Dapper;

var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=QuickenROcketMortgage1111!");

//Get All products from the products table 
List<Product> p1 = db.GetAll<Product>().ToList();
foreach(Product p in p1)
{
    Console.WriteLine(p);
}

////Lets add a new product 
//Product newProduct = new Product() { name = "Pizza", description = "Italian", price = 9.99m, inventory = 10, category = "FROZEN" };
//db.Insert(newProduct); 

////Lets Delete items 
//db.Delete(new Product() { id = 16 });
//db.Delete(new Product() { id = 14 }); 
//db.Delete(new Product() { id = 13 });
//db.Delete(new Product() { id = 17 });

////Read single item 
//Product productReview = db.Get<Product>(15);
//Console.WriteLine("Lets review a product here!");
//Console.WriteLine(productReview);

////Lets make changes to Pizza!
//Product productChange = db.Get<Product>(15);
//productChange.name = "Bread"; 
//db.Update<Product>(productChange);

//Use a Query 
Console.WriteLine();
Console.WriteLine("Items where price is greater than $5");
Console.WriteLine();
List<Product> queryList = db.Query<Product>("select * from product where price > 5").ToList();
foreach(Product p in queryList)
{
    Console.WriteLine(String.Join(", ", p));
}

//Print all meat 
Console.WriteLine();
Console.WriteLine("Lets print all meat items");
List<Product> meatList = db.Query<Product>("select * from product where category = 'Meat'").ToList(); 
foreach(Product p in meatList)
{
    Console.WriteLine(p);
}