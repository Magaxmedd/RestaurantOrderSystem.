namespace RestaurantOrderSystem.DAL.Entities
{
    public class MenuItem:BaseEntity
    {
      
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;
        public OrderItem OrderItem { get; set; } = null!;
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;
    }
}