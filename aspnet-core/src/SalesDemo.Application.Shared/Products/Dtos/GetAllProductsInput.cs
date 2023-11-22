using Abp.Application.Services.Dto;
using System;

namespace SalesDemo.Products.Dtos
{
    public class GetAllProductsInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

        public string NameFilter { get; set; }

        public string SkuFilter { get; set; }

    }
}