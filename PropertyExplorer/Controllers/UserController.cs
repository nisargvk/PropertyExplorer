using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
