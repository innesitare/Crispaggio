using Crispaggio.Domain.CustomerInfo;
namespace Crispaggio.Domain.Orders;

public sealed class Order
{
    public required Guid Id { get; init; }
    
    public required Guid CustomerId { get; init; }
    
    public required OrderStatus OrderStatus { get; init; }
    
    public required DeliveryAddress DeliveryAddress { get; init; }
    
    public required IEnumerable<OrderItem> OrderItems { get; init; }
}