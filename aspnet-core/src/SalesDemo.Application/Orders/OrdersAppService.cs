using SalesDemo.Customers;
using SalesDemo.Products;

using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using SalesDemo.Orders.Dtos;
using SalesDemo.Dto;
using Abp.Application.Services.Dto;
using SalesDemo.Authorization;
using Abp.Extensions;
using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using Abp.UI;
using SalesDemo.Storage;

namespace SalesDemo.Orders
{
    [AbpAuthorize(AppPermissions.Pages_Orders)]
    public class OrdersAppService : SalesDemoAppServiceBase, IOrdersAppService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Customer, int> _lookup_customerRepository;
        private readonly IRepository<Product, int> _lookup_productRepository;

        public OrdersAppService(IRepository<Order> orderRepository, IRepository<Customer, int> lookup_customerRepository, IRepository<Product, int> lookup_productRepository)
        {
            _orderRepository = orderRepository;
            _lookup_customerRepository = lookup_customerRepository;
            _lookup_productRepository = lookup_productRepository;

        }

        public virtual async Task<PagedResultDto<GetOrderForViewDto>> GetAll(GetAllOrdersInput input)
        {

            var filteredOrders = _orderRepository.GetAll()
                        .Include(e => e.CustomerFk)
                        .Include(e => e.ProductFk)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Status.Contains(input.Filter))
                        .WhereIf(!string.IsNullOrWhiteSpace(input.CustomerFirstNameFilter), e => e.CustomerFk != null && e.CustomerFk.FirstName == input.CustomerFirstNameFilter)
                        .WhereIf(!string.IsNullOrWhiteSpace(input.ProductNameFilter), e => e.ProductFk != null && e.ProductFk.Name == input.ProductNameFilter);

            var pagedAndFilteredOrders = filteredOrders
                .OrderBy(input.Sorting ?? "id asc")
                .PageBy(input);

            var orders = from o in pagedAndFilteredOrders
                         join o1 in _lookup_customerRepository.GetAll() on o.CustomerId equals o1.Id into j1
                         from s1 in j1.DefaultIfEmpty()

                         join o2 in _lookup_productRepository.GetAll() on o.ProductId equals o2.Id into j2
                         from s2 in j2.DefaultIfEmpty()

                         select new
                         {

                             o.Status,
                             Id = o.Id,
                             CustomerFirstName = s1 == null || s1.FirstName == null ? "" : s1.FirstName.ToString(),
                             ProductName = s2 == null || s2.Name == null ? "" : s2.Name.ToString()
                         };

            var totalCount = await filteredOrders.CountAsync();

            var dbList = await orders.ToListAsync();
            var results = new List<GetOrderForViewDto>();

            foreach (var o in dbList)
            {
                var res = new GetOrderForViewDto()
                {
                    Order = new OrderDto
                    {

                        Status = o.Status,
                        Id = o.Id,
                    },
                    CustomerFirstName = o.CustomerFirstName,
                    ProductName = o.ProductName
                };

                results.Add(res);
            }

            return new PagedResultDto<GetOrderForViewDto>(
                totalCount,
                results
            );

        }

        [AbpAuthorize(AppPermissions.Pages_Orders_Edit)]
        public virtual async Task<GetOrderForEditOutput> GetOrderForEdit(EntityDto input)
        {
            var order = await _orderRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetOrderForEditOutput { Order = ObjectMapper.Map<CreateOrEditOrderDto>(order) };

            if (output.Order.CustomerId != null)
            {
                var _lookupCustomer = await _lookup_customerRepository.FirstOrDefaultAsync((int)output.Order.CustomerId);
                output.CustomerFirstName = _lookupCustomer?.FirstName?.ToString();
            }

            if (output.Order.ProductId != null)
            {
                var _lookupProduct = await _lookup_productRepository.FirstOrDefaultAsync((int)output.Order.ProductId);
                output.ProductName = _lookupProduct?.Name?.ToString();
            }

            return output;
        }

        public virtual async Task CreateOrEdit(CreateOrEditOrderDto input)
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

        [AbpAuthorize(AppPermissions.Pages_Orders_Create)]
        protected virtual async Task Create(CreateOrEditOrderDto input)
        {
            var order = ObjectMapper.Map<Order>(input);

            if (AbpSession.TenantId != null)
            {
                order.TenantId = (int)AbpSession.TenantId;
            }

            await _orderRepository.InsertAsync(order);

        }

        [AbpAuthorize(AppPermissions.Pages_Orders_Edit)]
        protected virtual async Task Update(CreateOrEditOrderDto input)
        {
            var order = await _orderRepository.FirstOrDefaultAsync((int)input.Id);
            ObjectMapper.Map(input, order);

        }

        [AbpAuthorize(AppPermissions.Pages_Orders_Delete)]
        public virtual async Task Delete(EntityDto input)
        {
            await _orderRepository.DeleteAsync(input.Id);
        }

        [AbpAuthorize(AppPermissions.Pages_Orders)]
        public async Task<PagedResultDto<OrderCustomerLookupTableDto>> GetAllCustomerForLookupTable(GetAllForLookupTableInput input)
        {
            var query = _lookup_customerRepository.GetAll().WhereIf(
                   !string.IsNullOrWhiteSpace(input.Filter),
                  e => e.FirstName != null && e.FirstName.Contains(input.Filter)
               );

            var totalCount = await query.CountAsync();

            var customerList = await query
                .PageBy(input)
                .ToListAsync();

            var lookupTableDtoList = new List<OrderCustomerLookupTableDto>();
            foreach (var customer in customerList)
            {
                lookupTableDtoList.Add(new OrderCustomerLookupTableDto
                {
                    Id = customer.Id,
                    DisplayName = customer.FirstName?.ToString()
                });
            }

            return new PagedResultDto<OrderCustomerLookupTableDto>(
                totalCount,
                lookupTableDtoList
            );
        }

        [AbpAuthorize(AppPermissions.Pages_Orders)]
        public async Task<PagedResultDto<OrderProductLookupTableDto>> GetAllProductForLookupTable(GetAllForLookupTableInput input)
        {
            var query = _lookup_productRepository.GetAll().WhereIf(
                   !string.IsNullOrWhiteSpace(input.Filter),
                  e => e.Name != null && e.Name.Contains(input.Filter)
               );

            var totalCount = await query.CountAsync();

            var productList = await query
                .PageBy(input)
                .ToListAsync();

            var lookupTableDtoList = new List<OrderProductLookupTableDto>();
            foreach (var product in productList)
            {
                lookupTableDtoList.Add(new OrderProductLookupTableDto
                {
                    Id = product.Id,
                    DisplayName = product.Name?.ToString()
                });
            }

            return new PagedResultDto<OrderProductLookupTableDto>(
                totalCount,
                lookupTableDtoList
            );
        }

    }
}