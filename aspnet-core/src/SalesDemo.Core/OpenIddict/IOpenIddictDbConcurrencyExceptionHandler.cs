using System.Threading.Tasks;
using Abp.Domain.Uow;

namespace SalesDemo.OpenIddict
{
    public interface IOpenIddictDbConcurrencyExceptionHandler
    {
        Task HandleAsync(AbpDbConcurrencyException exception);
    }
}