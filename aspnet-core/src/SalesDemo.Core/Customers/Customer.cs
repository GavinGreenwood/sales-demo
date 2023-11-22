using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace SalesDemo.Customers
{
    [Table("Customers")]
    public class Customer : Entity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        [Required]
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        [RegularExpression(CustomerConsts.PhoneRegex)]
        public virtual string Phone { get; set; }

        [Required]
        [RegularExpression(CustomerConsts.EmailRegex)]
        public virtual string Email { get; set; }

    }
}