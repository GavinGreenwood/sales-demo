using System.Threading.Tasks;
using Abp.Webhooks;

namespace SalesDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
