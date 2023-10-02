using System.Reflection;
using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderItemApi.Persistence;

internal sealed class OrderItemDbContext : DbContext, IOrderItemDbContext
{
    public required DbSet<OrderItem> OrderItems { get; init; }

    public OrderItemDbContext(DbContextOptions<OrderItemDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}