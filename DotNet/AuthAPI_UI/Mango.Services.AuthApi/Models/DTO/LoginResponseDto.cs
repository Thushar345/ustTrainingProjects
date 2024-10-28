namespace Mango.Services.AuthApi.Models.DTO
{
    public class LoginResponseDto
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
