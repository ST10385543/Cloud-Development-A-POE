using Microsoft.AspNetCore.Mvc;
using ST10385543_CLDV6211_Part1.Business.Cart;
using ST10385543_CLDV6211_Part1.Data;
using ST10385543_CLDV6211_Part1.Data.Migrations;
using ST10385543_CLDV6211_Part1.Models.Transaction;

namespace ST10385543_CLDV6211_Part1.Controllers
{
    public class ShoppingCartController(ShoppingCartManager shoppingCartManager, ApplicationDbContext context) : Controller
    {
       
        public IActionResult Index()
        {
            return View(shoppingCartManager.GetCartHandler());
        }

        public IActionResult AddToCart(int productId, int quantity) 
        { 
            var product = context.Product.FirstOrDefault(x => x.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            var cart = shoppingCartManager.GetCartHandler();
            cart.AddItem(product,quantity);
            shoppingCartManager.SaveCartHandler(cart);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var cart = shoppingCartManager.GetCartHandler();
            cart.RemoveItem(productId);
            shoppingCartManager.SaveCartHandler(cart);

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = shoppingCartManager.GetCartHandler();
            if (cart.GetItems().Count == 0)
            {
                return RedirectToAction("Index");
            }

            var userEmail = HttpContext.User.Identity.Name;
            var userId = context.UserAccount.FirstOrDefault(x => x.EmailAddress == userEmail)?.Id;

            var order = new Orders
            {
                UserId = (int)userId,
                OrderDate = DateTime.Now,
            };
            context.Orders.Add(order);
            var orderId = context.SaveChanges();

            var orderDetails = cart.GetItems().Select(item => new OrderDetail
            {
                OrderId = order.Id,
                ProductId = item.Product.Id,
                Quantity = item.Quantity,
                UnitPrice = item.Product.Price
            }).ToList();

            foreach (var item in orderDetails)
            {
                context.OrdersDetail.Add(item);
                context.SaveChanges();
            }

            return RedirectToAction("Index","Home");
        }
    }
}
