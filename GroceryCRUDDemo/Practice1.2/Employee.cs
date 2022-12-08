
using Dapper.Contrib.Extensions;

[Table("employee")]
public class Employee
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }    
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Department_id { get; set; }
    public DateTime HireDate { get; set; }
}