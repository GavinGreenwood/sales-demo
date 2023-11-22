using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SalesDemo.Orders.Dtos;
using SalesDemo.Dto;

namespace SalesDemo.Orders
{
    public interface IOrdersAppService : IApplicationService
    {
        Task<PagedResultDto<GetOrderForViewDto>> GetAll(GetAllOrdersInput input);

        Task<GetOrderForEditOutput> GetOrderForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditOrderDto input);

        Task Delete(EntityDto input);

        Task<PagedResultDto<OrderCustomerLookupTableDto>> GetAllCustomerForLookupTable(GetAllForLookupTableInput input);

        Task<PagedResultDto<OrderProductLookupTableDto>> GetAllProductForLookupTable(GetAllForLookupTableInput input);

    }
}