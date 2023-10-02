using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders.Handlers;

internal sealed class DeleteOrderByIdCommandHandler(IOrderRepository orderRepository) 
    : ICommandHandler<DeleteOrderByIdCommand, bool>
{
    public async Task<bool> Handle(DeleteOrderByIdCommand request, CancellationToken cancellationToken)
    {
        bool deleted = await orderRepository.DeleteByIdAsync(request.Id, cancellationToken);
        return deleted;
    }
}