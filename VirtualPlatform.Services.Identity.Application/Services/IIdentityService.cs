using System;
using System.Threading.Tasks;
using VirtualPlatform.Services.Identity.Application.Commands;
using VirtualPlatform.Services.Identity.Application.DTO;

namespace VirtualPlatform.Services.Identity.Application.Services
{
    public interface IIdentityService
    {
        Task<UserDto> GetAsync(Guid id);
        Task<AuthDto> SignInAsync(SignIn command);
        Task SignUpAsync(SignUp command);
    }
}