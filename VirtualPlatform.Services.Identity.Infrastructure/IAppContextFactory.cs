using VirtualPlatform.Services.Identity.Application;

namespace VirtualPlatform.Services.Identity.Infrastructure
{
    public interface IAppContextFactory
    {
        IAppContext Create();
    }
}