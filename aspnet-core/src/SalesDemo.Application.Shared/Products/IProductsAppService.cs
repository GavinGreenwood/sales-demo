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
        Task CreateOrEdit(CreateOrEditProductDto input);
    }
}