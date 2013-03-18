using System.Web.Mvc;
using KnockoutSamples.Models;

namespace KnockoutSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ConferenceSetup()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            var model = new ProfileViewModel
            {
                UserName = "radenko",
                FirstName = "Radenko",
                LastName = "Zec",
                Email = "radenko.zec@something.com",
                Address = "Veselina Maslese 1"
            };

            return View(model);
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}