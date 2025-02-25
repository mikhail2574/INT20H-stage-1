using System;
using System.Threading.Tasks;
using Convey.Persistence.MongoDB;
using VirtualPlatform.Services.Identity.Core.Entities;
using VirtualPlatform.Services.Identity.Core.Repositories;
using VirtualPlatform.Services.Identity.Infrastructure.Mongo.Documents;

namespace VirtualPlatform.Services.Identity.Infrastructure.Mongo.Repositories
{
    internal sealed class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly IMongoRepository<RefreshTokenDocument, Guid> _repository;

        public RefreshTokenRepository(IMongoRepository<RefreshTokenDocument, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<RefreshToken> GetAsync(string token)
        {
            var refreshToken = await _repository.GetAsync(x => x.Token == token);

            return refreshToken?.AsEntity();
        }

        public Task AddAsync(RefreshToken token) => _repository.AddAsync(token.AsDocument());

        public Task UpdateAsync(RefreshToken token) => _repository.UpdateAsync(token.AsDocument());
    }
}