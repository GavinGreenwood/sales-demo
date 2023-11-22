using Abp.Application.Services.Dto;

namespace SalesDemo.Products.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}