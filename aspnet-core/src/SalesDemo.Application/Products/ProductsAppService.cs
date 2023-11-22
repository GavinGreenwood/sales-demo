using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using SalesDemo.Products.Dtos;
using SalesDemo.Dto;
using Abp.Application.Services.Dto;
using SalesDemo.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using SalesDemo.Storage;

namespace SalesDemo.Products
{
    [AbpAuthorize(AppPermissions.Pages_Products)]
    public class ProductsAppService : SalesDemoAppServiceBase, IProductsAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;

        }

        public virtual async Task<GetProductForViewDto> GetProductForView(int id)
        {
            var product = await _productRepository.GetAsync(id);

            var output = new GetProductForViewDto { Product = ObjectMapper.Map<ProductDto>(product) };

            return output;
        }

        [AbpAuthorize(AppPermissions.Pages_Products_Edit)]
        public virtual async Task<GetProductForEditOutput> GetProductForEdit(EntityDto input)
        {
            var product = await _productRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetProductForEditOutput { Product = ObjectMapper.Map<CreateOrEditProductDto>(product) };

            return output;
        }

        public virtual async Task CreateOrEdit(CreateOrEditProductDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }

        [AbpAuthorize(AppPermissions.Pages_Products_Edit)]
        protected virtual async Task Update(CreateOrEditProductDto input)
        {
            var product = await _productRepository.FirstOrDefaultAsync((int)input.Id);
            ObjectMapper.Map(input, product);
        }

        [AbpAuthorize(AppPermissions.Pages_Products_Create)]
        protected virtual async Task Create(CreateOrEditProductDto input)
        {
            var product = ObjectMapper.Map<Product>(input);

            await _productRepository.InsertAsync(product);
        }

        [AbpAuthorize(AppPermissions.Pages_Products_Delete)]
        public virtual async Task Delete(EntityDto input)
        {
            await _productRepository.DeleteAsync(input.Id);
        }
    }
}