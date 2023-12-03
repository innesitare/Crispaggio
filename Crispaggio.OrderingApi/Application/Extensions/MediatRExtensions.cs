using Crispaggio.OrderingApi.Application.Messaging.MediatR;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.PostProcessors;

namespace Crispaggio.OrderingApi.Application.Extensions;

public static class MediatRExtensions
{
    public static IServiceCollection AddMediator(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddMediatR(configuration =>
        {
            configuration.Lifetime = ServiceLifetime.Scoped;
            configuration.AddRequestPostProcessor<OrderPostProcessor>();
            configuration.RegisterServicesFromAssemblyContaining<IMediatRAssemblyMarker>();
        });
    }
}