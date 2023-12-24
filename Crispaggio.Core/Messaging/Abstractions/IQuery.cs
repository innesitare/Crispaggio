using MediatR;

namespace Crispaggio.Core.Messaging.Abstractions;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}