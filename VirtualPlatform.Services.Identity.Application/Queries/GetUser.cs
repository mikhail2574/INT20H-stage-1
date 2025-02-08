using System;
using Convey.CQRS.Queries;
using VirtualPlatform.Services.Identity.Application.DTO;

namespace VirtualPlatform.Services.Identity.Application.Queries
{
    public class GetUser : IQuery<UserDto>
    {
        public Guid UserId { get; set; }
    }
}