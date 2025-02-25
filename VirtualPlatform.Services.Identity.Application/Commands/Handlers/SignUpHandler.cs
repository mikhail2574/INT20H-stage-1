using System.Threading.Tasks;
using Convey.CQRS.Commands;
using VirtualPlatform.Services.Identity.Application.Services;

namespace VirtualPlatform.Services.Identity.Application.Commands.Handlers
{
    // Simple wrapper
    internal sealed class SignUpHandler : ICommandHandler<SignUp>
    {
        private readonly IIdentityService _identityService;

        public SignUpHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public Task HandleAsync(SignUp command) => _identityService.SignUpAsync(command);
    }
}