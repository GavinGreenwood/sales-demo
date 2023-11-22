using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace SalesDemo.Orders.Dtos
{
    public class CreateOrEditOrderDto : EntityDto<int?>
    {

        public string Status { get; set; }

        public int? CustomerId { get; set; }

        public int? ProductId { get; set; }

    }
}