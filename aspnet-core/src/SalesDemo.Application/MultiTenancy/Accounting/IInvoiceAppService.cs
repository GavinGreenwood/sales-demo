using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using SalesDemo.MultiTenancy.Accounting.Dto;

namespace SalesDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
