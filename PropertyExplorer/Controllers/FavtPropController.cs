﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyExplorer.Models;
using Microsoft.AspNetCore.Mvc;

namespace GropProject3.Controllers
{
    public class FavtPropController : Controller
    {
        private readonly IFavouriteProperty client;

        public FavtPropController(IFavouriteProperty client)
        {

            this.client = client;

        }

        public IActionResult FavouriteProperties()
        {

            return View(client.GetAllFavtProperty());

        }
        public IActionResult AddToList(int propertyId)
        {
            User activeUser = SessionHelper.GetObjectFromJson<User>(HttpContext.Session, "userObject");
            int userId = activeUser.Id;
            client.Add(userId, propertyId);
            return RedirectToAction("showMyList");
        }

        public IActionResult showMyList(int userId)
        {
            User activeUser = SessionHelper.GetObjectFromJson<User>(HttpContext.Session, "userObject");
            userId = activeUser.Id;

            return View(client.GetByUserId(userId));
        }
    }
}
