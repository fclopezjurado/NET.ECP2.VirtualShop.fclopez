using System.Linq;
using System.Web.Mvc;
using VirtualShop.Models;

namespace VirtualShop.Controllers
{
    public class HomeController : Controller
    {
        private virtualshopEntities db = new virtualshopEntities();

        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}