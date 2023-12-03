using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Contracts.Requests.Orders;
using Crispaggio.OrderingApi.Application.Contracts.Responses.Orders;
using Riok.Mapperly.Abstractions;

namespace Crispaggio.OrderingApi.Application.Mappers;

[Mapper]
internal static partial class OrderMapper
{
    public static partial OrderResponse ToResponse(this Order order);
    
    private static partial Order ToOrder(this CreateOrderRequest request);

    public static Order ToOrder(this CreateOrderRequest request, Guid customerId)
    {
        request.CustomerId = customerId;
        return request.ToOrder();
    }
}