using System.Web.Mvc;
using KnockoutSamples.Models;

namespace KnockoutSamples.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult ConferenceSetup()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyProfile()
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

        // Sample for using JsonNetResult (serializing to camel case)
        public ActionResult GetProfile(int id)
        {
            return Json(new ProfileViewModel
            {
                UserName = "radenko",
                FirstName = "Radenko",
                LastName = "Zec",
                Email = "radenko.zec@something.com",
                Address = "Veselina Maslese 1"
            }, JsonRequestBehavior.AllowGet);
        }
    }
}