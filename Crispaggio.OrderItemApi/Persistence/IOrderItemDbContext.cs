using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderItemApi.Persistence;

public interface IOrderItemDbContext
{
    public DbSet<OrderItem> OrderItems { get; init; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}