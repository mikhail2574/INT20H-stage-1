using System;
using System.Threading.Tasks;
using VirtualPlatform.Services.Identity.Core.Entities;

namespace VirtualPlatform.Services.Identity.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
    }
}