using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.MultiTenancy.Payments.Dto;
using SalesDemo.MultiTenancy.Payments.Stripe.Dto;

namespace SalesDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}