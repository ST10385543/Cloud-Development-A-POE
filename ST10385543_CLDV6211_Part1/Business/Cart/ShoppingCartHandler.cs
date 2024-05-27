using ST10385543_CLDV6211_Part1.Models.Cart;
using ST10385543_CLDV6211_Part1.Models.Product;

namespace ST10385543_CLDV6211_Part1.Business.Cart
{
    public class ShoppingCartHandler
    {
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public void AddItem(Product product, int quantity)
        {
            var existingItems = Items.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingItems != null)
            {
                existingItems.Quantity += quantity;
            }

            Items.Add(new ShoppingCartItem { Product = product, Quantity = quantity });
        }

        public void RemoveItem(int productId)
        {
            var cartItem = Items.FirstOrDefault(x => x.Product.Id == productId);
            if (cartItem != null)
            {
                Items.Remove(cartItem);
            }
        }

        public List<ShoppingCartItem> GetItems()
        {
            return Items;
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(x => x.TotalPrice);
        }
    }
}
