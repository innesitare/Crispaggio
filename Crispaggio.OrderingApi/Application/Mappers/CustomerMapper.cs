using Crispaggio.Domain.CustomerInfo;
using Crispaggio.OrderingApi.Application.Contracts.Responses.Customers;
using Riok.Mapperly.Abstractions;

namespace Crispaggio.OrderingApi.Application.Mappers;

[Mapper]
internal static partial class CustomerMapper
{
    public static partial CustomerResponse ToResponse(this Customer customer);
}