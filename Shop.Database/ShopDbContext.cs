
namespace Shop.Database
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Shop.Domain.Models;
    
    
    public class ShopDbContext : IdentityDbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
        : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
