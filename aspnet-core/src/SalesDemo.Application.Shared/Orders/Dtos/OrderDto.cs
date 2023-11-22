using System;
using Abp.Application.Services.Dto;

namespace SalesDemo.Orders.Dtos
{
    public class OrderDto : EntityDto
    {
        public string Status { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

    }
}