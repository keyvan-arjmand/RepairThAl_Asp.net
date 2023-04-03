using DAL.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _123Pair.Controllers
{
    public class OrderController : Controller
    {
        private UserManager<UserApp> userManager;

        private SignInManager<UserApp> signInManager;
        public OrderController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        public IActionResult Insert(Order order)
        {
            DB db = new DB();
            DAL.Services.Order_Services _Order = new DAL.Services.Order_Services();
            User user = db.users.Where(x => x.Email == User.Identity.Name).FirstOrDefault();
            _Order.Insert(order, user.User__ID);
            return RedirectToAction("UserProfile", "Account");
        }
        [HttpPost]
        public IActionResult Update(Order order)
        {
            DAL.Services.Order_Services _Order = new DAL.Services.Order_Services();
            _Order.Edit(order);
            return RedirectToAction("Orders", "AdminPanel");
        }
        [HttpPost]
        public IActionResult Delete(Order order)
        {
            DAL.Services.Order_Services _Order = new DAL.Services.Order_Services();
            _Order.Delete(order);
            return RedirectToAction("Orders", "AdminPanel");
        }
        [HttpPost]
        public DAL.DTOs.OrderViewModel GetOrderByID(Order order)
        {
            DB db = new DB();
            DAL.Services.Order_Services _Order = new DAL.Services.Order_Services();
            return _Order.GetOrder(order.Order__ID);
        }
    }
}
