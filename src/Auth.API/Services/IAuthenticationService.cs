using Auth.API.DTO;
using FluentResults;

namespace Auth.API.Services;

public interface IAuthenticationService
{
    Task<Result<string>> Register(RegisterRequest request);
    Task<Result<string>> Login(LoginRequest request);
}