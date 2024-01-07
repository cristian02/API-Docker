using Microsoft.EntityFrameworkCore;
using MyMicroservice.Models;
namespace MyMicroservice.Data;

public class AppDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            // Replace "YourColumnType" with the appropriate SQL Server column type for your 'Price' property
            entity.Property(e => e.Price)
                .HasColumnType("decimal")
                .HasPrecision(18, 2); // Adjust precision and scale based on your requirements
        });
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}