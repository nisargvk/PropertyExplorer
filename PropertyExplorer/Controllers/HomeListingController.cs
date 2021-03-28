using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Controllers
{
    public class HomeListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
