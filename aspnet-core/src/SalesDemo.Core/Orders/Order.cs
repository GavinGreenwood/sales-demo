using SalesDemo.Customers;
using SalesDemo.Products;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace SalesDemo.Orders
{
    [Table("Orders")]
    public class Order : Entity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public virtual string Status { get; set; }

        public virtual int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer CustomerFk { get; set; }

        public virtual int? ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product ProductFk { get; set; }

    }
}