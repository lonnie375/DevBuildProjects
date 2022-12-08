using System.ComponentModel.DataAnnotations;

namespace WorkOutLog.Models
{
    public class Log
    {
        //Code First Approach
        //Now Time to learn how to use MySQL 
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string WorkOut { get; set; }
        public DateTime Created { get; set; }   = DateTime.Now;
    }


}
