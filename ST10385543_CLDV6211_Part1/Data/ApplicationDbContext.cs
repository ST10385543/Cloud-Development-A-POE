using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10385543_CLDV6211_Part1.Models.Product;
using ST10385543_CLDV6211_Part1.Models.Transaction;

namespace ST10385543_CLDV6211_Part1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ST10385543_CLDV6211_Part1.Models.Product.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<ST10385543_CLDV6211_Part1.Models.Product.Product> Product { get; set; } = default!;
        public DbSet<ST10385543_CLDV6211_Part1.Models.User.UserAccount> UserAccount { get; set; } = default!;
        public DbSet<ST10385543_CLDV6211_Part1.Models.Transaction.Orders> Orders { get; set; } = default!;
        public DbSet<ST10385543_CLDV6211_Part1.Models.Transaction.OrderDetail> OrdersDetail { get; set; } = default!;
    }
}
