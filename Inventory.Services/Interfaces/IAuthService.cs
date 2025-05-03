using Inventory.Services.DTOs.Auth;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
        Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
    }
}
