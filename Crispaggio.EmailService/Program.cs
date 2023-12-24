using Crispaggio.Core.Extensions;
using Crispaggio.EmailService.Application.Messages.Consumers;
using Crispaggio.EmailService.Application.Services.Abstractions;
using Crispaggio.OrderingApi.Application.Settings;
using MassTransit;
using Microsoft.Extensions.Options;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Configuration.AddAzureKeyVault();

builder.Services.AddApplicationService<IEmailService>();

builder.Services.AddFluentEmail("crispaggio.team@proton.me")
    .AddMailGunSender(builder.Configuration["MailGun:DomainName"], builder.Configuration["MailGun:ApiKey"])
    .AddRazorRenderer();

builder.Services.AddOptions<RabbitMqSettings>()
    .Bind(builder.Configuration.GetSection(RabbitMqSettings.SectionName))
    .ValidateOnStart();

builder.Services.AddMassTransit(x =>
{
    x.SetKebabCaseEndpointNameFormatter();
    
    x.AddConsumer<UserRegistrationCompletedConsumer>();
    x.AddConsumer<SendOrderReadyConsumer>();
    
    x.UsingRabbitMq((context, cfg) =>
    {
        var rabbitMqSettings = context.GetRequiredService<IOptions<RabbitMqSettings>>().Value;
        cfg.Host(rabbitMqSettings.Host, RabbitMqSettings.VirtualHost, hostConfigurator =>
        {
            hostConfigurator.Username(rabbitMqSettings.Username);
            hostConfigurator.Password(rabbitMqSettings.Password);
        });

        cfg.UseNewtonsoftJsonSerializer();
        cfg.UseNewtonsoftJsonDeserializer();

        cfg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

app.Run();