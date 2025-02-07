using Convey.CQRS.Commands;

namespace VirtualPlatform.UserManagementService.Application.Commands;
public class CreateUserCommand : ICommand
{
    public string FirebaseUid { get; set; }
    public string Email { get; set; }
    public string DisplayName { get; set; }
    public string AvatarUrl { get; set; }
}
