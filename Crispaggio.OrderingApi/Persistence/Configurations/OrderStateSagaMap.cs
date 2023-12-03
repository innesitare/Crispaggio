using Crispaggio.OrderingApi.Application.StateMachines.SagaInstances;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderingApi.Persistence.Configurations;

internal sealed class OrderStateSagaMap : SagaClassMap<OrderState>
{
    protected override void Configure(EntityTypeBuilder<OrderState> entity, ModelBuilder model)
    {
        entity.HasKey(x => x.CorrelationId);
        
        entity.Property(x => x.CurrentState)
            .IsRequired();
        
        entity.Property(x => x.CorrelationId)
            .IsRequired();
        
        entity.Property(x => x.OrderId)
            .IsRequired();
    }
}