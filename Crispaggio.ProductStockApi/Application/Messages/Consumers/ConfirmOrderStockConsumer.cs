using Crispaggio.Messages.Ordering.Commands;
using Crispaggio.Messages.Ordering.Responses;
using Crispaggio.ProductStockApi.Application.Repositories.Abstractions;
using MassTransit;

namespace Crispaggio.ProductStockApi.Application.Messages.Consumers;

public sealed class ConfirmOrderStockConsumer(IProductRepository productRepository) : IConsumer<ConfirmStock>
{
    public async Task Consume(ConsumeContext<ConfirmStock> context)
    {
        var orderItems = context.Message.Order.OrderItems;
        var products = await productRepository.GetAllAsync(context.CancellationToken);
        
        foreach (var product in products)
        {
            var orderItem = orderItems.FirstOrDefault(orderItem => orderItem.Id == product.Id);
            if (orderItem is null)
            {
                await context.RespondAsync<Fault<ConfirmStock>>(context.Message);
                return;
            }

            product.Quantity -= orderItem.Quantity;
            if (product.Quantity < 1)
            {
                await context.RespondAsync<Fault<ConfirmStock>>(context.Message);
                return;
            }

            await productRepository.UpdateAsync(product, context.CancellationToken);
        }

        await context.RespondAsync<StockConfirmed>(new 
        {
            context.Message.Order
        });
    }
}