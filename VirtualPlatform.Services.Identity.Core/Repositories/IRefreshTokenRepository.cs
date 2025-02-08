using System.Threading.Tasks;
using VirtualPlatform.Services.Identity.Core.Entities;

namespace VirtualPlatform.Services.Identity.Core.Repositories
{
    public interface IRefreshTokenRepository
    {
        Task<RefreshToken> GetAsync(string token);
        Task AddAsync(RefreshToken token);
        Task UpdateAsync(RefreshToken token);
    }
}