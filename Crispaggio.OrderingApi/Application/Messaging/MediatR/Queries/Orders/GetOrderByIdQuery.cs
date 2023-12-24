using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders;

public sealed class GetOrderByIdQuery : IQuery<Order?>
{
    public required Guid Id { get; init; }
}