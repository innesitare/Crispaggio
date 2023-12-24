using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders.Handlers;

internal sealed class GetAllOrdersByCustomerIdQueryHandler(IOrderRepository orderRepository) 
    : IQueryHandler<GetAllOrdersByCustomerIdQuery, IEnumerable<Order>>
{
    public async Task<IEnumerable<Order>> Handle(GetAllOrdersByCustomerIdQuery request, CancellationToken cancellationToken)
    {
        var orders = await orderRepository.GetAllByCustomerId(request.CustomerId, cancellationToken);
        return orders;
    }
}