namespace RestaurantOrderSystem.DAL.Entities
{
    public class OrderItem:BaseEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
         
    }
}