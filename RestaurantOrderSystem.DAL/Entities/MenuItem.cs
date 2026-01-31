namespace RestaurantOrderSystem.DAL.Entities
{
    public class MenuItem:BaseEntity
    {
      
 
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;
        public Order? Orderİtem { get; set; }
        public int? OrderId { get; set; }
    }
}