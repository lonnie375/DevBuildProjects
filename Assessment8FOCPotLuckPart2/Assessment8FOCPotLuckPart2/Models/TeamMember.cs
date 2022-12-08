using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Assessment8FOCPotLuckPart2.Models
{
    [Table("teammember")]
    public class TeamMember
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }    
        public string emailaddress { get; set; }
        public DateTime attendancedate { get; set; }
        public string guestname { get; set; }
    }
}
