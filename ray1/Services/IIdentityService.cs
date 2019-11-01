using System;
using System.Threading.Tasks;
using ray1.Domain;

namespace ray1.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string Email, string Password);
    }
}
