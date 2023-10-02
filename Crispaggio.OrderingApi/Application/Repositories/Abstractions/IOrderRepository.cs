using Crispaggio.Domain.Orders;

namespace Crispaggio.OrderingApi.Application.Repositories.Abstractions;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllAsync(CancellationToken cancellationToken);

    Task<IEnumerable<Order>> GetAllByCustomerId(Guid customerId, CancellationToken cancellationToken);

    Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> CreateAsync(Order order, CancellationToken cancellationToken);

    Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
}