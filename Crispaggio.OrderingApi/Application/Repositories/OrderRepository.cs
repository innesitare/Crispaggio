using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;
using Crispaggio.OrderingApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Application.Repositories;

internal sealed class OrderRepository(IOrderingDbContext orderingDbContext) : IOrderRepository
{
    public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancellationToken)
    {
        bool hasDrones = await orderingDbContext.Orders.AnyAsync(cancellationToken);
        if (!hasDrones)
        {
            return Enumerable.Empty<Order>();
        }
        
        return orderingDbContext.Orders;
    }

    public async Task<IEnumerable<Order>> GetAllByCustomerId(Guid customerId, CancellationToken cancellationToken)
    {
        var orders = await orderingDbContext.Orders
            .Where(o => o.CustomerId == customerId)
            .ToListAsync(cancellationToken);

        return orders;
    }

    public async Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var order = await orderingDbContext.Orders.FindAsync(new object?[] {id}, cancellationToken);
        return order;
    }

    public async Task<bool> CreateAsync(Order order, CancellationToken cancellationToken)
    {
        await orderingDbContext.Orders.AddAsync(order, cancellationToken);
        int result = await orderingDbContext.SaveChangesAsync(cancellationToken);

        return result > 0;
    }

    public async Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        int result = await orderingDbContext.Orders
            .Where(o => o.Id == id)
            .ExecuteDeleteAsync(cancellationToken);

        return result > 0;
    }
}