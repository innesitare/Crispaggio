using MassTransit;

namespace Crispaggio.OrderingApi.Application.StateMachines.SagaInstances;

public class OrderState : SagaStateMachineInstance
{
    public required Guid CorrelationId { get; set; }
    
    public required int CurrentState { get; set; }
    
    public required Guid OrderId { get; set; }
}