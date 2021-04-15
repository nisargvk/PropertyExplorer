using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyExplorer.Models;

namespace PropertyExplorer.Controllers
{
    public class HomeListingController
    {
        private readonly IHomeListingRepository homeListingRepository;

        public HomeListingController(IHomeListingRepository homeListingRepository)
        {
            this.homeListingRepository = homeListingRepository;
        }

        public IActionResult CreateHomeListing()
        {
           // User activeUser = SessionHelper.GetObjectFromJson<User>(HttpContext.Session, "userObject");
           // ViewBag.userId = activeUser.Id;
           return View();
        }
    }
}
