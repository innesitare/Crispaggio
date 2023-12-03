using Crispaggio.ProductStockApi.Application.Contracts.Requests;
using Crispaggio.ProductStockApi.Application.Contracts.Responses;
using Crispaggio.ProductStockApi.Application.Models;
using Riok.Mapperly.Abstractions;

namespace Crispaggio.ProductStockApi.Application.Mappers;

[Mapper]
internal static partial class ProductMapper
{
    public static partial ProductResponse ToResponse(this Product product);
    
    public static partial Product ToProduct(this CreateProductRequest request);

    private static partial Product ToProduct(this UpdateProductRequest request);

    public static Product ToProduct(this UpdateProductRequest request, Guid id)
    {
        request.Id = id;
        return request.ToProduct();
    }
}