using Crispaggio.Messages.Ordering.Commands;
using Crispaggio.Messages.Ordering.Responses;
using Crispaggio.OrderingApi.Application.StateMachines.SagaInstances;
using MassTransit;

namespace Crispaggio.OrderingApi.Application.StateMachines;

internal sealed class OrderStateMachine : MassTransitStateMachine<OrderState>
{
    private readonly ILogger<OrderStateMachine> _logger;
    
    public required State Submitted { get; init; }

    public required State Confirmed { get; init; }

    public required State Paid { get; init; }
    
    public required State Completed { get; init; }

    public required State Cancelled { get; init; }

    public OrderStateMachine()
    {
        InstanceState(x => x.CurrentState, Submitted, Confirmed, Paid, Completed, Cancelled);

        Event(() => SubmitOrder, x => x.CorrelateById(ctx => ctx.Message.Order.Id));

        Request(() => ConfirmStock, r => { r.Timeout = TimeSpan.Zero; });

        Request(() => RegisterPayment, r => { r.Timeout = TimeSpan.Zero; });

        Initially(
            When(SubmitOrder)
                .Then(ctx => ctx.Saga.OrderId = ctx.Message.Order.Id)
                .Request(ConfirmStock, ctx => ctx.Init<ConfirmStock>(new {ctx.Message.Order}))
                .TransitionTo(Submitted));

        During(Submitted,
            When(ConfirmStock?.Completed)
                .Request(RegisterPayment, ctx => ctx.Init<RegisterPayment>(new {ctx.Message.Order}))
                .TransitionTo(Confirmed),
            When(ConfirmStock?.Faulted)
                .TransitionTo(Cancelled));
        
        During(Confirmed,
            When(RegisterPayment?.Completed)
                .TransitionTo(Completed),
            When(RegisterPayment?.Faulted)
                .TransitionTo(Cancelled));
        
        WhenEnter(Completed, binder => binder.Finalize());
        WhenEnter(Cancelled, binder => binder.Finalize());
        
        SetCompletedWhenFinalized();
    }

    public Event<SubmitOrder> SubmitOrder { get; private set; }
    
    public Request<OrderState, ConfirmStock, StockConfirmed> ConfirmStock { get; private set; }

    public Request<OrderState, RegisterPayment, PaymentConfirmed> RegisterPayment { get; private set; }
}