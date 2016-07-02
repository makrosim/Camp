﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampNetwork.Models;

namespace CampNetwork.Controllers
{
    public class HomeController : Controller
    {
        CampContext db = new CampContext();

        [HttpGet]
        public ActionResult Index()
        {
            User currUser = db.Users.Find(1);

            ViewBag.User = currUser;

            var artlist = new List<Article>();
            foreach(var art in currUser.CampPlaces)
                artlist.AddRange(art.Articles);

            ViewBag.Articles = artlist;

            return View();
        }
    }
}