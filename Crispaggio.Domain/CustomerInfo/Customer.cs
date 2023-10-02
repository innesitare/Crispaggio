using Crispaggio.Domain.Orders;

namespace Crispaggio.Domain.CustomerInfo;

public sealed class Customer
{
    public required Guid Id { get; init; }
    
    public required Guid? PartyGroupId { get; init; }
    
    public required string Username { get; init; }
    
    public required string Email { get; init; }
    
    public required string PhotoUrl { get; init; }
    
    public required int LoyaltyPoints { get; init; }
    
    public required IEnumerable<Customer>? Friends { get; init; }
    
    public required IEnumerable<DeliveryAddress>? DeliveryAddresses { get; init; }
    
    public required IEnumerable<Order>? Orders { get; init; }
}