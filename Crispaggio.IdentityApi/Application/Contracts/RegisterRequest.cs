﻿namespace Crispaggio.IdentityApi.Application.Contracts;

public sealed class RegisterRequest
{
    public required string Email { get; init; }
    
    public required string Password { get; init; }
}