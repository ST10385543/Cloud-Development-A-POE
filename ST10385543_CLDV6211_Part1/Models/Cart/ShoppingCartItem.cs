namespace ST10385543_CLDV6211_Part1.Models.Cart
{
    using ST10385543_CLDV6211_Part1.Models.Product;
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;
    }
}
