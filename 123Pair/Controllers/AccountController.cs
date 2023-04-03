using DAL.Model;
using DAL.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pair.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<UserApp> userManager;

        private SignInManager<UserApp> signInManager;
        public AccountController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult UserProfile()
        {
            if (User.Identity.IsAuthenticated)
            {
                DB db = new DB();
                DAL.Services.Order_Services order_Services = new DAL.Services.Order_Services();
                DAL.Services.User_Services User_Service = new DAL.Services.User_Services();
                var UserModel = User_Service.GetByEmail(User.Identity.Name);
                ViewBag.Orders = order_Services.GetOrders(db.users.Where(x => x.Email == User.Identity.Name).Select(x => x.User__ID).FirstOrDefault());
                if (UserModel.IsAdmin)
                {
                    return RedirectToAction("Index", "AdminPanel");
                }
                return View();
            }
            return RedirectToAction("index", "Home");
        }
        public IActionResult SignUpPage()
        {
            return View();
        }
        public IActionResult OrderPage()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View("views/account/concatus.cshtml");
        }


        [HttpPost]
        public async Task<IActionResult> login(User user)
        {
            var UserEntiny = await userManager.FindByNameAsync(user.Email);
            DAL.Services.User_Services User_Service = new DAL.Services.User_Services();
            var UserModel = User_Service.GetByEmail(user.Email);
            if (UserEntiny == null)
            {
                throw new Exception("کاربر با این نام کاربری وجود ندارد");
            }

            if (!UserModel.IsAdmin)
            {

                var signinresult = await signInManager.PasswordSignInAsync(UserEntiny, user.Password, true, false);

                if (!signinresult.Succeeded)
                {
                    throw new Exception("نام کاربری یا رمز عبور اشتباه است");
                }

                return RedirectToAction("index", "Home");

            }
            else if (UserModel.IsAdmin)
            {
                var signinresult = await signInManager.PasswordSignInAsync(UserEntiny, user.Password, true, false);
                if (!signinresult.Succeeded)
                {
                    throw new Exception("نام کاربری یا رمز عبور اشتباه است");
                }


                return RedirectToAction("Index", "AdminPanel");

            }
            return RedirectToAction("index", "Home");

        }
        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            DAL.Services.User_Services _User = new DAL.Services.User_Services();

            var userEntiny = await userManager.FindByNameAsync(user.Email);

            if (userEntiny != null)
            {
                throw new Exception("کاربر با این مشخصات وجود دارد");
            }
            else
            {
                var idenUser = new UserApp
                {
                    Email = user.Email,
                    Lastname = user.LastName,
                    Firstname = user.FirstName,
                    UserName = user.Email,
                    PhoneNumber = user.PhoneNumber,

                };

                _User.Insert(user);
                var adduser = await userManager.CreateAsync(idenUser, user.Password);

                return RedirectToAction("Index", "Home", adduser);

            }

        }
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            else return RedirectToAction("Index", "Home");


        }
    }
}
