using CoffeeShopRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopRegistration.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Registration> Registration { get; set; }
    }
}
