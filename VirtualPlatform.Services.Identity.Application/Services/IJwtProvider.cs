using System;
using System.Collections.Generic;
using VirtualPlatform.Services.Identity.Application.DTO;

namespace VirtualPlatform.Services.Identity.Application.Services
{
    public interface IJwtProvider
    {
        AuthDto Create(Guid userId, string role, string audience = null,
            IDictionary<string, IEnumerable<string>> claims = null);
    }
}