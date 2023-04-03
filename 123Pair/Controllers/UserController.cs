using DAL.Model;
using DAL.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pair.Controllers
{
    public class UserController : Controller
    {
        private UserManager<UserApp> userManager;
        public UserController(UserManager<UserApp> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<ActionResult> InsertUser(User user)
        {
            DAL.Services.User_Services _User = new DAL.Services.User_Services();
            UserApp userapp = new UserApp
            {
                Email = user.Email,
                Lastname = user.LastName,
                Firstname = user.FirstName,
                UserName = user.Email,
                PhoneNumber = user.PhoneNumber,

            };
            var result = await userManager.CreateAsync(userapp, user.PhoneNumber);
            _User.Insert(user);
            return RedirectToAction("Index", "Home", result);

        }
        [HttpPost]
        public async Task<ActionResult> EditUser(User user)
        {
            DAL.Services.User_Services _User = new DAL.Services.User_Services();
            var User = _User.GetUsers().Where(x => x.User__ID == user.User__ID).SingleOrDefault();
            var userIden = userManager.FindByNameAsync(User.Email).Result;
            if (userIden != null)
            {
                userIden.Email = user.Email;
                userIden.Lastname = user.LastName;
                userIden.Firstname = user.FirstName;
                userIden.UserName = user.Email;
                userIden.PhoneNumber = user.PhoneNumber;
                var result = await userManager.UpdateAsync(userIden);
            }
            _User.Update(user);
            return RedirectToAction("UserProfile", "Account", user);
        }
        public async Task<ActionResult> DeleteUser(User user)
        {
            DAL.Services.User_Services _User = new DAL.Services.User_Services();
            var userIden = userManager.FindByNameAsync(user.Email).Result;
            if (userIden != null)
            {
                var result = await userManager.DeleteAsync(userIden);
            }
            _User.Delete(user);
            return RedirectToAction("Users", "AdminPanel");
        }

    }
}
