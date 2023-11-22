using System;
using Abp.Application.Services.Dto;

namespace SalesDemo.Products.Dtos
{
    public class ProductDto : EntityDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Sku { get; set; }

    }
}