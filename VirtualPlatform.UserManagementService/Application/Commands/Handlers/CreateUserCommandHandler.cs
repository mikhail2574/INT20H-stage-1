using Convey.CQRS.Commands;
using VirtualPlatform.UserManagementService.Core.Entities;

namespace VirtualPlatform.UserManagementService.Application.Commands.Handlers;
public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    public Task HandleAsync(CreateUserCommand command, CancellationToken cancellationToken = default)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirebaseUid = command.FirebaseUid,
            Email = command.Email,
            DisplayName = command.DisplayName,
            AvatarUrl = command.AvatarUrl
        };

        // Persist the user using your repository of choice

        return Task.CompletedTask;
    }
}
