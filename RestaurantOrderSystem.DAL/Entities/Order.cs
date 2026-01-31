using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem.DAL.Entities
{
    public class Order:BaseEntity
    {
    

        public List<OrderItem> OrderItems { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime Date { get; set; }
    }
}
