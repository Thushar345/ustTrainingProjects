using Mango.Services.AuthApi.Models.DTO;
using Microsoft.AspNetCore.Identity.Data;

namespace Mango.Services.AuthApi.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDTO registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
