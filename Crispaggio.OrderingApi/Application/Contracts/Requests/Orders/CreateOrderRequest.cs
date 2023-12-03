using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Contracts.Requests.DeliveryAddresses;

namespace Crispaggio.OrderingApi.Application.Contracts.Requests.Orders;

public sealed class CreateOrderRequest
{
    public Guid Id { get; internal set; }
    
    public Guid CustomerId { get; internal set; }
    
    public OrderStatus OrderStatus { get; init; }
    
    public CreateDeliveryAddressRequest DeliveryAddress { get; init; }
    
    public IEnumerable<OrderItem> OrderItems { get; init; }
}