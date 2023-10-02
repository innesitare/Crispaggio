using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders.Handlers;

internal sealed class GetOrderByIdQueryHandler(IOrderRepository orderRepository) 
    : IQueryHandler<GetOrderByIdQuery, Order?>
{
    public async Task<Order?> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.GetByIdAsync(request.Id, cancellationToken);
        return order;
    }
}