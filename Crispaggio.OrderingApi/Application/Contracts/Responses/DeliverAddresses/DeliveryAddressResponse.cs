namespace Crispaggio.OrderingApi.Application.Contracts.Responses.DeliverAddresses;

public sealed class DeliveryAddressResponse
{
    public required Guid Id { get; init; }

    public required string Postcode { get; init; }

    public required string HouseNumber { get; init; }

    public required int? UnitNumber { get; init; }
}