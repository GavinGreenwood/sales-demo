using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace SalesDemo.Products
{
    [Table("Products")]
    public class Product : Entity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        [Required]
        [StringLength(ProductConsts.MaxNameLength, MinimumLength = ProductConsts.MinNameLength)]
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        [StringLength(ProductConsts.MaxSkuLength, MinimumLength = ProductConsts.MinSkuLength)]
        public virtual string Sku { get; set; }

    }
}