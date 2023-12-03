using Crispaggio.EmailService.Application.Services.Abstractions;
using Crispaggio.Messages.Mailing;
using MassTransit;

namespace Crispaggio.EmailService.Application.Messages.Consumers;

public sealed class SendOrderReadyConsumer(IEmailService emailService) : IConsumer<SendOrderReady>
{
    public async Task Consume(ConsumeContext<SendOrderReady> context)
    {
        await emailService.SendOrderReadyAsync(context.Message.Email, context.Message.OrderId,
            context.CancellationToken);
    }
}