using Microsoft.EntityFrameworkCore;
using shopdemo.Configurations;
using shopdemo.Data.Model;

namespace shopdemo.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Item> Items {  get; set; } 
        public DbSet<User> Users { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Cart_Item> CartItems { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfigurations());
            modelBuilder.ApplyConfiguration(new CartItemConfigurations());
            
        }
    }
}
