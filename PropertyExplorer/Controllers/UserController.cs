using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository userRepository;

        public object FormsAuthentication { get; private set; }

        public UserController(IUserRepository userRepository)
        {

            this.userRepository = userRepository;

        }
        [HttpPost]
        public IActionResult SignUp(User user, string RoleName)
        {


            if (ModelState.IsValid)
            {


                userRepository.Add(user);
                return RedirectToAction("Login");

            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user, string ReturnUrl)
        {
            var activeUser = userRepository.GetAnUser(user);
            if (activeUser != null)
            {
                HttpContext.Session.SetString("username", activeUser.Username);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "userObject", activeUser);
                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    ViewBag.session = HttpContext.Session.GetString("username");
                    return Redirect("~/Home/index");
                }

            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userObject");
            HttpContext.Session.Clear();
            return Redirect("~/Home/Index");
        }


    }
}
