using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders;

public sealed class GetAllOrdersByCustomerIdQuery : IQuery<IEnumerable<Order>>
{
    public required Guid CustomerId { get; init; }
}

