using System.Threading.Tasks;
using SalesDemo.Authorization.Users;

namespace SalesDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
