using System.Threading.Tasks;
using Convey.CQRS.Queries;
using VirtualPlatform.UserManagementService.Core.Entities;

namespace VirtualPlatform.UserManagementService.Application.Queries.Handlers;
public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, User>
{
    public Task<User> HandleAsync(GetUserByIdQuery query, CancellationToken cancellationToken = default)
    {
        // Retrieve the user by Id from your database

        // For demonstration purposes, returning a mock user
        return Task.FromResult(new User
        {
            Id = query.Id,
            FirebaseUid = "mockFirebaseUid",
            Email = "mock@example.com",
            DisplayName = "Mock User",
            AvatarUrl = "http://example.com/avatar.png"
        });
    }
}
