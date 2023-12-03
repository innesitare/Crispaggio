using Crispaggio.OrderingApi.Application.Contracts.Responses.DeliverAddresses;
using Crispaggio.OrderingApi.Application.Contracts.Responses.Orders;

namespace Crispaggio.OrderingApi.Application.Contracts.Responses.Customers;

public sealed class CustomerResponse
{
    public required Guid Id { get; init; }
    
    public required Guid? PartyGroupId { get; init; }
    
    public required string Username { get; init; }
    
    public required string Email { get; init; }
    
    public required string PhotoUrl { get; init; }
    
    public required int LoyaltyPoints { get; init; }
    
    public required IEnumerable<CustomerResponse>? Friends { get; init; }
    
    public required IEnumerable<DeliveryAddressResponse>? DeliveryAddresses { get; init; }
    
    public required IEnumerable<OrderResponse>? Orders { get; init; }
}