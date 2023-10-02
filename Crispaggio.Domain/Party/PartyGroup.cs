using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;
using StronglyTypedIds;

namespace Crispaggio.Domain.Party;

[StronglyTypedId]
public partial struct PartyGroupId;

public sealed class PartyGroup
{
    public required PartyGroupId Id { get; init; }
    
    public required Order? Order { get; init; }
    
    public required IEnumerable<Customer> Customers { get; init; }
}