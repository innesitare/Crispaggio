using StronglyTypedIds;

namespace Crispaggio.Domain.CustomerInfo;

[StronglyTypedId(converters: StronglyTypedIdConverter.EfCoreValueConverter)]
public partial struct DeliveryAddressId { }

public sealed class DeliveryAddress
{
    public required DeliveryAddressId Id { get; init; }

    public required string Postcode { get; init; }

    public required string HouseNumber { get; init; }

    public required int? UnitNumber { get; init; }
}