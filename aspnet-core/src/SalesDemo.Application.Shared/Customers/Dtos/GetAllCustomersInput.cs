using Abp.Application.Services.Dto;
using System;

namespace SalesDemo.Customers.Dtos
{
    public class GetAllCustomersInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

        public string FirstNameFilter { get; set; }

        public string LastNameFilter { get; set; }

        public string PhoneFilter { get; set; }

        public string EmailFilter { get; set; }

    }
}