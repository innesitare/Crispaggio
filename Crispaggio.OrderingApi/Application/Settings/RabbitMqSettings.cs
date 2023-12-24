namespace Crispaggio.OrderingApi.Application.Settings;

public sealed class RabbitMqSettings
{
    public const string SectionName = "RabbitMq";

    public const string VirtualHost = "/";

    public required string Host { get; init; }
    
    public required string Username { get; init; }
    
    public required string Password { get; init; }
}