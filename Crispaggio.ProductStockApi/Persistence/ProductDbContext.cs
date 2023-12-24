using System.Reflection;
using Crispaggio.Domain.Orders;
using Crispaggio.ProductStockApi.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.ProductStockApi.Persistence;

internal sealed class ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions) 
    : DbContext(dbContextOptions), IProductDbContext
{
    public required DbSet<Topic> Topics { get; init; }
    
    public required DbSet<Product> Products { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}