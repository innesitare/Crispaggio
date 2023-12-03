using Crispaggio.Core.Extensions;
using Crispaggio.OrderingApi.Application.Settings;
using Crispaggio.ProductApi.Persistence;
using Crispaggio.ProductStockApi.Application.Messages.Consumers;
using Crispaggio.ProductStockApi.Application.Repositories.Abstractions;
using Crispaggio.ProductStockApi.Persistence;
using MassTransit;
using Microsoft.Extensions.Options;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddControllers();
builder.Services.AddJwtBearer(builder.Configuration);

builder.Services.AddApplicationDatabase<IProductDbContext, ProductDbContext>(
    builder.Configuration["ProductsDb:ConnectionString"]!);

builder.Services.AddApplicationService<IProductRepository>();

builder.Services.AddOptions<RabbitMqSettings>()
    .Bind(builder.Configuration.GetSection(RabbitMqSettings.SectionName))
    .ValidateOnStart();

builder.Services.AddMassTransit(x =>
{
    x.SetKebabCaseEndpointNameFormatter();
    x.AddConsumersFromNamespaceContaining<ConfirmOrderStockConsumer>();

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

app.MapControllers();
app.MapHealthChecks("/_health");

app.Run();