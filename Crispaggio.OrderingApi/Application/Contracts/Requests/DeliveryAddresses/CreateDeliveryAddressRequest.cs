namespace Crispaggio.OrderingApi.Application.Contracts.Requests.DeliveryAddresses;

public sealed class CreateDeliveryAddressRequest
{
    public Guid Id { get; init; }
    
    public Guid CustomerId { get; init; }

    public string Postcode { get; init; }

    public string HouseNumber { get; init; }

    public int? UnitNumber { get; init; }
}