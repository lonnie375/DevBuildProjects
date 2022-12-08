using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using Dapper; 

namespace GroceryCRUDDemo.Models
{
    //Functionality to access our data 
    //This is the "data access layer"
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=QuickenROcketMortgage1111!;");

        //CRUD operations for our Category table 

        // Read all 

        public static List<Category> GetAllCategories()
        {
            // We can call "Dal.GetAllCategories()" to get all of the categories that we have in our database
            return DB.GetAll<Category>().ToList();
        }

        // Read one 
        public static Category GetOneCategory(string id)
        {
            return DB.Get<Category>(id);
        }

        // Create One (insert) 
        public static Category InsertCategory(Category cat)
        {
             DB.Insert<Category>(cat);
            return cat;
        }


        // Delete One
        public static void DeleteCategory(string id)
        {
            // Delete all Products in this category. (Make sure user understands this!!)
            // Use Dappers tool to prevent SQL injection attacks 
            // Example: id is Fruit
            // We're building an anyonymous object that looks like this: 
            //  {
            //      catid: "FRUIT"
            //  }
            // Dapper will then find #catid and replace it with 'FRUIT'
            // to build the SQL string. 
            // example: 
            //   delete from product where category=@catid
            //   delete from product where category='FRUIT'

            DB.Execute($"delete from product where category=@catid", new {catid=id}); 
            Category cat = new Category();
            cat.id = id; 
            DB.Delete<Category>(cat);
        }

        // Update one (edit) 
        public static void UpdateCategory(Category cat)
        {
            DB.Update<Category>(cat);   
            
        }

        //CRUD operations for our Product table 

        // Read all 
        public static List<Product> GetAllProducts()
        {
            return DB.GetAll<Product>().ToList();
        }

        // Read one 
        public static Product GetProduct(int id)
        {
            return DB.Get<Product>(id); 
        }

        // Create One (insert) 
        public static Product InsertProduct(Product prod)
        {
            //The insert function takes n instance of Product. 
            // So the insert function knows what class and therefore 
            // What table to use. 
            DB.Insert<Product>(prod);
            return prod;
        }


        // Delete One
        public static void DeleteProduct(int id)
        {
            Product prod = new Product();
            prod.Id = id;
            DB.Delete<Product>(prod);
            
        }

        // Update one (edit) 
        public static void UpdateProduct(Product prod)
        {
            DB.Update(prod);
        }
        
        //
    }
}
