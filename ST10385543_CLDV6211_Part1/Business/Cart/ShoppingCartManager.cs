using System.Text.Json;

namespace ST10385543_CLDV6211_Part1.Business.Cart
{
    public class ShoppingCartManager
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public ShoppingCartManager(IHttpContextAccessor httpContextAccessor)
        {
            _contextAccessor = httpContextAccessor;
        }
        private ISession Session => _contextAccessor.HttpContext.Session;
        public ShoppingCartHandler GetCartHandler()
        {
            var cartJson = Session.GetString("cart");
            if (String.IsNullOrEmpty(cartJson))
            {
                return new ShoppingCartHandler();
            }

            return JsonSerializer.Deserialize<ShoppingCartHandler>(cartJson);
        }

        public void SaveCartHandler(ShoppingCartHandler handler)
        {
            var cartJson = JsonSerializer.Serialize(handler);
            Session.SetString("cart",cartJson);
        }
    }
}
