using System.Threading.Tasks;
using Convey.CQRS.Events;

namespace VirtualPlatform.Services.Identity.Application.Services
{
    public interface IMessageBroker
    {
        Task PublishAsync(params IEvent[] events);
    }
}