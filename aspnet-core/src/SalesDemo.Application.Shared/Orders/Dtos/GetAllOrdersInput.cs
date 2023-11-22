using Abp.Application.Services.Dto;
using System;

namespace SalesDemo.Orders.Dtos
{
    public class GetAllOrdersInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

        public string CustomerFirstNameFilter { get; set; }

        public string ProductNameFilter { get; set; }

    }
}