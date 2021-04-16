using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropertyExplorer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Test()
        {

            return "This is test";

        }
        public IActionResult CreateListing()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
