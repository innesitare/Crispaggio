using Crispaggio.Core.Extensions;
using Crispaggio.OrderingApi.Application.Extensions;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;
using Crispaggio.OrderingApi.Application.Settings;
using Crispaggio.OrderingApi.Application.StateMachines;
using Crispaggio.OrderingApi.Application.StateMachines.SagaInstances;
using Crispaggio.OrderingApi.Application.Validators;
using Crispaggio.OrderingApi.Persistence;
using FluentValidation;
using FluentValidation.AspNetCore;
using MassTransit;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault();

builder.Services.AddControllers();
builder.Services.AddMediator();

builder.Services.AddApplicationDatabase<IOrderingDbContext, OrderingDbContext>(
    builder.Configuration["OrderingDb:ConnectionString"]!);

builder.Services.AddApplicationDatabase<OrderingSagaDbContext>(
    builder.Configuration["OrderingStateDb:ConnectionString"]!);

builder.Services.AddCacheStackService(builder.Configuration);

builder.Services.AddApplicationService<IOrderRepository>();
builder.Services.AddApplicationService<ICustomerRepository>();

builder.Services.AddOptions<RabbitMqSettings>()
    .Bind(builder.Configuration.GetSection(RabbitMqSettings.SectionName))
    .ValidateOnStart();

builder.Services.AddMassTransit(x =>
{
    x.SetKebabCaseEndpointNameFormatter();
    x.AddSagaStateMachine<OrderStateMachine, OrderState>()
        .EntityFrameworkRepository(r =>
        {
            r.ExistingDbContext<OrderingSagaDbContext>();
            r.UsePostgres();
        });

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

builder.Services.AddFluentValidationAutoValidation()
    .AddValidatorsFromAssemblyContaining<IValidationMarker>(ServiceLifetime.Singleton, includeInternalTypes: true);

builder.Services.AddHealthChecksService(builder.Configuration);

var app = builder.Build();

app.UseHealthChecks("/_health");
app.MapControllers();

app.Run();