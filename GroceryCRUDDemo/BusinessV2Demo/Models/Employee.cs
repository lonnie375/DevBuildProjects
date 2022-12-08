using Dapper.Contrib.Extensions;
namespace BusinessV2Demo.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string department { get; set; }

        public DateTime hiredate { get; set; }
    }
}
