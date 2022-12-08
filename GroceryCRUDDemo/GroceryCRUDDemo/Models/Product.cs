using Dapper.Contrib.Extensions; 
namespace GroceryCRUDDemo.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public string Category { get; set; }

    }
}
