using Microsoft.EntityFrameworkCore;

namespace BuildsByBrickwell.Models
{
    public class IntexContext: DbContext
    {
        public IntexContext(DbContextOptions<IntexContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
