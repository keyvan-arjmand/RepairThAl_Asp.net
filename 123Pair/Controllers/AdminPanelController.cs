using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _123Pair.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("~/Views/AdminPanel/Dashboard.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Orders()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("~/Views/AdminPanel/Orders_Admin.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Users()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("~/Views/AdminPanel/Users_Admin.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ProfileAdmin()
        {
            if (User.Identity.IsAuthenticated)
            {
                DB db = new DB();
                DAL.Services.Order_Services order_Services = new DAL.Services.Order_Services();
                ViewBag.Orders = order_Services.GetOrders(db.users.Where(x => x.Email == User.Identity.Name).Select(x => x.User__ID).FirstOrDefault());

                return View("~/Views/AdminPanel/Profile.cshtml");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
