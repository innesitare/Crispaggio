using MediatR;

namespace Crispaggio.Core.Messaging.Abstractions;

public interface IQueryHandler<TQuery, TResponse> 
    : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}