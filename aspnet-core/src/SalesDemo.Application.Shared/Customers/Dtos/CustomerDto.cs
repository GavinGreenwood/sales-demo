using System;
using Abp.Application.Services.Dto;

namespace SalesDemo.Customers.Dtos
{
    public class CustomerDto : EntityDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }
}