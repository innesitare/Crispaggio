using Crispaggio.Core.Messaging.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders;

public sealed class DeleteOrderByIdCommand : ICommand<bool>
{
    public required Guid Id { get; init; }
    
    public required Guid CustomerId { get; init; }
}