using Convey.CQRS.Queries;
using VirtualPlatform.UserManagementService.Core.Entities;

namespace VirtualPlatform.UserManagementService.Application.Queries;

public class GetUserByIdQuery : IQuery<User>
{
    public Guid Id { get; set; }
}
