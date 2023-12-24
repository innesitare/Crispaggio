namespace Crispaggio.ProductStockApi.Application.Contracts.Requests;

public sealed class DeleteProductRequest
{
    public required Guid Id { get; init; }
}