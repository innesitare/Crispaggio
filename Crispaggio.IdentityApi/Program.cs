using Crispaggio.Core.Extensions;
using Crispaggio.IdentityApi.Application.Extensions;
using Crispaggio.IdentityApi.Application.Services.Abstractions;
using Crispaggio.OrderingApi.Application.Settings;
using MassTransit;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault();

builder.Services.AddControllers();
builder.Services.AddFirebaseAuth(builder.Configuration);

builder.Services.AddApplicationService<IAuthService>();

builder.Services.AddOptions<RabbitMqSettings>()
    .Bind(builder.Configuration.GetSection(RabbitMqSettings.SectionName))
    .ValidateOnStart();

builder.Services.AddMassTransit(x =>
{
    x.SetKebabCaseEndpointNameFormatter();
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

builder.Services.AddHealthChecksService(builder.Configuration);

var app = builder.Build();

app.UseHealthChecks("/_health");
app.MapControllers();

app.Run();