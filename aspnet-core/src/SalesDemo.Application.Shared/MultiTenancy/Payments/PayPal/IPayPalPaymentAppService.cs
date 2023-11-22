using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.MultiTenancy.Payments.PayPal.Dto;

namespace SalesDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
