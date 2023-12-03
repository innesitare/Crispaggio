using Crispaggio.EmailService.Application.Services.Abstractions;
using FluentEmail.Core;

namespace Crispaggio.EmailService.Application.Services;

internal sealed class EmailService(IFluentEmail fluentEmail) : IEmailService
{
    public async Task<bool> UserRegistrationCompletedAsync(string email, CancellationToken cancellationToken)
    {
        var emailResponse = await fluentEmail.UsingTemplateFromFile(
                $"{Directory.GetCurrentDirectory()}/Application/Templates/UserRegistrationCompletedTemplate.cshtml",
                new {Email = email})
            .To(email)
            .Subject("Registration Confirmation")
            .SendAsync();

        return emailResponse.Successful;
    }

    public async Task<bool> SendOrderReadyAsync(string email, Guid orderId, CancellationToken cancellationToken)
    {
        var emailResponse = await fluentEmail.UsingTemplateFromFile(
                $"{Directory.GetCurrentDirectory()}/Application/Templates/SendOrderReadyTemplate.cshtml",
                new {Email = email, OrderId = orderId})
            .To(email)
            .Subject("Your Order State")
            .SendAsync();

        return emailResponse.Successful;
    }
}