namespace SalesDemo.Orders.Dtos
{
    public class GetOrderForViewDto
    {
        public OrderDto Order { get; set; }

        public string CustomerFirstName { get; set; }

        public string ProductName { get; set; }

    }
}