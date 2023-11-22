using Abp.Application.Services.Dto;

namespace SalesDemo.Orders.Dtos
{
    public class OrderCustomerLookupTableDto
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }
    }
}