using System.ComponentModel.DataAnnotations;

namespace ST10385543_CLDV6211_Part1.Models.Transaction
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } // Add this if you have user authentication
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
