using Crispaggio.Domain.Orders;
using Crispaggio.Domain.Party;
using StronglyTypedIds;

namespace Crispaggio.Domain.CustomerInfo;

[StronglyTypedId]
public partial struct CustomerId;

public sealed class Customer
{
    public required CustomerId Id { get; init; }
    
    public required PartyGroupId? PartyGroupId { get; init; }
    
    public required string Username { get; init; }
    
    public required string Email { get; init; }
    
    public required int LoyaltyPoints { get; init; }
    
    public required IEnumerable<Customer>? Friends { get; init; }
    
    public required IEnumerable<DeliveryAddress>? DeliveryAddresses { get; init; }
    
    public required IEnumerable<Order>? Orders { get; init; }
}