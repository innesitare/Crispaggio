using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;

namespace Crispaggio.Domain.Party;

public sealed class PartyGroup
{
    public required Guid Id { get; init; }
    
    public required Order? Order { get; init; }
    
    public required IEnumerable<Customer> Customers { get; init; }
}