using System.Web.Mvc;
using VirtualShop.Models;

namespace VirtualShop.Controllers
{
    public class CartController : Controller
    {
        private virtualshopEntities db = new virtualshopEntities();

        // GET: Cart
        public ActionResult Index(Cart cart)
        {
            return View(cart);
        }

        // POST: Cart/AddToCart/1/20
        public ActionResult AddToCart(User user, Cart cart, int book, int price)
        {
            if (user.Email != null)
            {
                Order order     = new Order();
                order.user      = user.Email;
                order.quantity  = 1;
                order.price     = price;
                order.book      = book;

                cart.Add(order);
            }

            return RedirectToAction("Index", "Home");
        }

        // POST: Cart/ClearCart
        public ActionResult ClearCart(Cart cart)
        {
            cart.Clear();
            return RedirectToAction("Index", "Home");
        }

        // POST: Cart/MakeOrder
        public ActionResult MakeOrder(Cart cart)
        {
            foreach (Order order in cart)
            {
                db.Orders.Add(order);
            }

            db.SaveChanges();
            cart.Clear();

            return RedirectToAction("Index");
        }
    }
}