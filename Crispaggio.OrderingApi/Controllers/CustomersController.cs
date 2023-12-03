using Crispaggio.OrderingApi.Application.Contracts.Requests.Customers;
using Crispaggio.OrderingApi.Application.Helpers;
using Crispaggio.OrderingApi.Application.Mappers;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Crispaggio.OrderingApi.Controllers;

[ApiController]
public sealed class CustomersController(ISender sender) : ControllerBase
{
    [HttpGet(ApiEndpoints.Customers.Get)]
    public async Task<IActionResult> Get([FromRoute] GetCustomerByIdRequest request,
        CancellationToken cancellationToken)
    {
        var customer = await sender.Send(new GetCustomerByIdQuery
        {
            Id = request.Id
        }, cancellationToken);

        return customer is not null
            ? Ok(customer.ToResponse())
            : NotFound();
    } 
    
    [HttpGet(ApiEndpoints.Customers.GetByEmail)]
    public async Task<IActionResult> GetByEmail([FromRoute] GetCustomerByEmailRequest request,
        CancellationToken cancellationToken)
    {
        var customer = await sender.Send(new GetCustomerByEmailQuery
        {
            Email = request.Email
        }, cancellationToken);

        return customer is not null
            ? Ok(customer.ToResponse())
            : NotFound();
    } 
}