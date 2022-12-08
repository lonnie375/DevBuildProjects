using Dapper.Contrib.Extensions;

namespace Assessment8FOCPotLuckPart2.Models
{
    [Table("dish")]
    public class Dish
    {
        [Key]
        public int id { get; set; }
        public string tmname { get; set; }
        public string phonenumber { get; set; }
        public string dishname { get; set; }
        public string dishdescription { get; set; }
        public string category { get; set; }
    }
}
