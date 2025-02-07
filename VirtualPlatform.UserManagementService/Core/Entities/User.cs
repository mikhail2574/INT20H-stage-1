namespace VirtualPlatform.UserManagementService.Core.Entities;
public class User
{
    public Guid Id { get; set; }
    public string FirebaseUid { get; set; }
    public string Email { get; set; }
    public string DisplayName { get; set; }
    public string AvatarUrl { get; set; }
}