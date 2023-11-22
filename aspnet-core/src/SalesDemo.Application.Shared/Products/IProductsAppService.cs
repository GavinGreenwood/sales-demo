using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SalesDemo.Products.Dtos;
using SalesDemo.Dto;

namespace SalesDemo.Products
{
    public interface IProductsAppService : IApplicationService
    {
        Task<PagedResultDto<GetProductForViewDto>> GetAll(GetAllProductsInput input);

        Task<GetProductForViewDto> GetProductForView(int id);

        Task<GetProductForEditOutput> GetProductForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditProductDto input);

        Task Delete(EntityDto input);
    }
}