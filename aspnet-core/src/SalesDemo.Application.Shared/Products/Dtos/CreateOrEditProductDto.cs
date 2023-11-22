using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace SalesDemo.Products.Dtos
{
    public class CreateOrEditProductDto : EntityDto<int?>
    {

        [Required]
        [StringLength(ProductConsts.MaxNameLength, MinimumLength = ProductConsts.MinNameLength)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(ProductConsts.MaxSkuLength, MinimumLength = ProductConsts.MinSkuLength)]
        public string Sku { get; set; }

    }
}