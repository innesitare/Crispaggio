using Crispaggio.IdentityApi.Application.Contracts;
using Crispaggio.IdentityApi.Application.Helpers;
using Crispaggio.IdentityApi.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Crispaggio.IdentityApi.Controllers;

[ApiController]
public sealed class AuthController(IAuthService authService) : ControllerBase
{
    [HttpPost(ApiEndpoints.Auth.Register)]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request, CancellationToken cancellationToken)
    {
        string? token = await authService.RegisterAsync(request.Email, request.Password, cancellationToken);
        
        return token is not null
            ? Ok(token)
            : Unauthorized();
    }
    
    [HttpPost(ApiEndpoints.Auth.Login)]
    public async Task<IActionResult> Login([FromBody] LoginRequest request, CancellationToken cancellationToken)
    {
        string? token = await authService.LoginAsync(request.Email, request.Password, cancellationToken);
        
        return token is not null
            ? Ok(token)
            : Unauthorized();
    }
}