using Crispaggio.OrderingApi.Application.Contracts.Requests.Orders;
using Crispaggio.OrderingApi.Application.Helpers;
using Crispaggio.OrderingApi.Application.Mappers;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Crispaggio.OrderingApi.Controllers;

[ApiController]
public sealed class OrdersController(ISender sender) : ControllerBase
{
    [HttpGet(ApiEndpoints.Orders.GetAll)]
    public async Task<IActionResult> GetAllByCustomerId([FromRoute] GetAllOrdersByCustomerIdRequest request,
        CancellationToken cancellationToken)
    {
        var orders = await sender.Send(new GetAllOrdersByCustomerIdQuery
        {
            CustomerId = request.CustomerId
        }, cancellationToken);

        return Ok(orders);
    }

    [HttpGet(ApiEndpoints.Orders.Get)]
    public async Task<IActionResult> Get([FromRoute] GetOrderByIdRequest request,
        CancellationToken cancellationToken)
    {
        var order = await sender.Send(new GetOrderByIdQuery
        {
            Id = request.Id
        }, cancellationToken);

        return order is not null
            ? Ok(order.ToResponse())
            : NotFound();
    }

    [HttpPost(ApiEndpoints.Orders.Create)]
    public async Task<IActionResult> Create([FromRoute] Guid customerId, [FromBody] CreateOrderRequest request,
        CancellationToken cancellationToken)
    {
        var order = request.ToOrder(customerId);
        bool created = await sender.Send(new CreateOrderCommand
        {
            Order = order
        }, cancellationToken);

        return created
            ? CreatedAtAction("Get", new GetOrderByIdRequest {CustomerId = customerId, Id = order.Id}, order.ToResponse())
            : BadRequest();
    }

    [HttpDelete(ApiEndpoints.Orders.Delete)]
    public async Task<IActionResult> Delete([FromRoute] DeleteOrderRequest request,
        CancellationToken cancellationToken)
    {
        bool deleted = await sender.Send(new DeleteOrderByIdCommand
        {
            Id = request.Id,
            CustomerId = request.CustomerId
        }, cancellationToken);

        return deleted
            ? NoContent()
            : NotFound();
    }
}