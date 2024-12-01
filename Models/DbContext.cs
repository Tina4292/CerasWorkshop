using Microsoft.EntityFrameworkCore;

namespace CerasWorkshop.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductOrder>().HasKey(p => new {p.ProductID, p.OrderID});
    }

    public DbSet<Product> Products {get; set;}
    public DbSet<Order> Orders {get; set;}
    public DbSet<ProductOrder> ProductOrders {get; set;}
}