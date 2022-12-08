using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistrationContinued.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
      
        public string Password { get; set; }
   
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
