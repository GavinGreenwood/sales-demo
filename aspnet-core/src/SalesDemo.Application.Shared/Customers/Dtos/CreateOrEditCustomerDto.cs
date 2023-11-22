using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace SalesDemo.Customers.Dtos
{
    public class CreateOrEditCustomerDto : EntityDto<int?>
    {

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [RegularExpression(CustomerConsts.PhoneRegex)]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(CustomerConsts.EmailRegex)]
        public string Email { get; set; }

    }
}