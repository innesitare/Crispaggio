using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Contracts.Responses.DeliverAddresses;

namespace Crispaggio.OrderingApi.Application.Contracts.Responses.Orders;

public sealed class OrderResponse
{
    public required Guid Id { get; init; }

    public required OrderStatus OrderStatus { get; init; }

    public required DeliveryAddressResponse DeliveryAddress { get; init; }

    public required IEnumerable<OrderItem> OrderItems { get; init; }
}