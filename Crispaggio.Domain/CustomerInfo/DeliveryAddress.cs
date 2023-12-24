namespace Crispaggio.Domain.CustomerInfo;

public sealed class DeliveryAddress
{
    public required Guid Id { get; init; }
    
    public required Guid CustomerId { get; init; }

    public required string Postcode { get; init; }

    public required string HouseNumber { get; init; }

    public required int? UnitNumber { get; init; }
}