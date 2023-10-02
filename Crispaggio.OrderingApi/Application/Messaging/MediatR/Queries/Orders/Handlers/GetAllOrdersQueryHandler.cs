using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders.Handlers;

internal sealed class GetAllOrdersQueryHandler(IOrderRepository orderRepository) 
    : IQueryHandler<GetAllOrdersQuery, IEnumerable<Order>>
{
    public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await orderRepository.GetAllAsync(cancellationToken);
        return orders;
    }
}