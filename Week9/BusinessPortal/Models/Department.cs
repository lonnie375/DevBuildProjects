using Dapper.Contrib.Extensions; 
namespace BusinessPortal.Models
{
    [Table("department")]
    public class Department
    {
        [ExplicitKey] //used this because the id doesn't auto-increment 
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }


    }
}
