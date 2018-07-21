﻿using NHibernate.Linq;
using SampleBlog.Models;
using SampleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SampleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin() {  });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            var user = Database.Session.Query<User>().FirstOrDefault(u => u.Username == form.Username);

            if (user == null)
                SampleBlog.Models.User.FakeHash();

            if (user == null || !user.CheckPassword(form.Password))
                ModelState.AddModelError("Username", "Username or Password is incorrect");

            if (ModelState.IsValid == false)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);

            if (string.IsNullOrWhiteSpace(returnUrl) == false)
                return Redirect(returnUrl);

            return RedirectToRoute("home");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}