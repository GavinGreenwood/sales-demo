using Abp.Application.Services.Dto;

namespace SalesDemo.Orders.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}