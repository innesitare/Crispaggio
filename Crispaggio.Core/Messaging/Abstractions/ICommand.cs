using MediatR;

namespace Crispaggio.Core.Messaging.Abstractions;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}