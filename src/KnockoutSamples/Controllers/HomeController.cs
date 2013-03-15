using System.Web.Mvc;

namespace KnockoutSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}