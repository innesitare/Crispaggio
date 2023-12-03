using Crispaggio.EmailService.Application.Services.Abstractions;
using Crispaggio.Messages.Mailing;
using MassTransit;

namespace Crispaggio.EmailService.Application.Messages.Consumers;

public sealed class UserRegistrationCompletedConsumer(IEmailService emailService) : IConsumer<UserRegistrationCompleted>
{
    public async Task Consume(ConsumeContext<UserRegistrationCompleted> context)
    {
        await emailService.UserRegistrationCompletedAsync(context.Message.Email, context.CancellationToken);
    }
}