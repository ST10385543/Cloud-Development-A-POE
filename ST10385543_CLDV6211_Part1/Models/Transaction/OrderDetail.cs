using System.ComponentModel.DataAnnotations;
using ST10385543_CLDV6211_Part1.Models.Product;
namespace ST10385543_CLDV6211_Part1.Models.Transaction
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public ST10385543_CLDV6211_Part1.Models.Product.Product Product { get; set; }
    }
}
