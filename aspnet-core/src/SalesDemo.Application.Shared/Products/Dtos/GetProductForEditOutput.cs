using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace SalesDemo.Products.Dtos
{
    public class GetProductForEditOutput
    {
        public CreateOrEditProductDto Product { get; set; }

    }
}