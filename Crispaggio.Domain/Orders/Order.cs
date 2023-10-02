using Crispaggio.Domain.CustomerInfo;
using StronglyTypedIds;

namespace Crispaggio.Domain.Orders;

[StronglyTypedId]
public partial struct OrderId;

public sealed class Order
{
    public required OrderId Id { get; init; }
    
    public required CustomerId CustomerId { get; init; }
    
    public required OrderStatus OrderStatus { get; init; }
    
    public required DeliveryAddress DeliveryAddress { get; init; }
    
    public required IEnumerable<OrderItem> OrderItems { get; init; }
}