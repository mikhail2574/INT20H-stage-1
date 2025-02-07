using Convey.CQRS.Commands;

namespace VirtualPlatform.Services.Identity.Application.Commands;

public class UseRefreshToken : ICommand
{
    public string RefreshToken { get; }

    public UseRefreshToken(string refreshToken)
    {
        RefreshToken = refreshToken;
    }
}