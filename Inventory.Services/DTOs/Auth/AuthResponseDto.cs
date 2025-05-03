using System.Collections.Generic;

namespace Inventory.Services.DTOs.Auth
{
    public class AuthResponseDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
        public IList<string> Roles { get; set; }
    }
}
