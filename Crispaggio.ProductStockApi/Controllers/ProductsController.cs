using Crispaggio.ProductStockApi.Application.Contracts.Requests;
using Crispaggio.ProductStockApi.Application.Helpers;
using Crispaggio.ProductStockApi.Application.Mappers;
using Crispaggio.ProductStockApi.Application.Repositories.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crispaggio.ProductStockApi.Controllers;

[ApiController]
[Authorize]
public sealed class ProductsController(IProductRepository productRepository) : ControllerBase
{
    [HttpGet(ApiEndpoints.Products.GetAll)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync(cancellationToken);
        var responses = products.Select(p => p.ToResponse());

        return Ok(responses);
    }

    [HttpGet(ApiEndpoints.Products.Get)]
    public async Task<IActionResult> Get([FromRoute] GetProductByIdRequest request,
        CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id, cancellationToken);
        return product is not null
            ? Ok(product.ToResponse())
            : NotFound();
    }

    [HttpPost(ApiEndpoints.Products.Create)]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request,
        CancellationToken cancellationToken)
    {
        var product = request.ToProduct();
        bool created = await productRepository.CreateAsync(product, cancellationToken);

        return created
            ? CreatedAtAction("Get", new {id = product.Id}, product.ToResponse())
            : BadRequest();
    }

    [HttpPost(ApiEndpoints.Products.Update)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateProductRequest request,
        CancellationToken cancellationToken)
    {
        var updatedProduct = await productRepository.UpdateAsync(request.ToProduct(id), cancellationToken);
        return updatedProduct is not null
            ? Ok(updatedProduct.ToResponse())
            : NotFound();
    }

    [HttpDelete(ApiEndpoints.Products.Delete)]
    public async Task<IActionResult> Delete([FromRoute] DeleteProductRequest request,
        CancellationToken cancellationToken)
    {
        bool deleted = await productRepository.DeleteByIdAsync(request.Id, cancellationToken);
        return deleted
            ? NoContent()
            : NotFound();
    }
}