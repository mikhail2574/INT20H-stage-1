using System;
using System.Threading.Tasks;
using Convey.CQRS.Queries;
using Convey.Persistence.MongoDB;
using VirtualPlatform.Services.Identity.Application.DTO;
using VirtualPlatform.Services.Identity.Application.Queries;
using VirtualPlatform.Services.Identity.Infrastructure.Mongo.Documents;

namespace VirtualPlatform.Services.Identity.Infrastructure.Mongo.Queries.Handlers
{
    internal sealed class GetUserHandler : IQueryHandler<GetUser, UserDto>
    {
        private readonly IMongoRepository<UserDocument, Guid> _userRepository;

        public GetUserHandler(IMongoRepository<UserDocument, Guid> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> HandleAsync(GetUser query)
        {
            var user = await _userRepository.GetAsync(query.UserId);

            return user?.AsDto();
        }
    }
}