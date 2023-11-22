using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace SalesDemo.Orders.Dtos
{
    public class GetOrderForEditOutput
    {
        public CreateOrEditOrderDto Order { get; set; }

        public string CustomerFirstName { get; set; }

        public string ProductName { get; set; }

    }
}