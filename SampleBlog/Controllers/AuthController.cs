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
        public  ActionResult Login()
        {
            return View(new AuthLogin() { Abc123 = "Hey it works...." });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if(ModelState.IsValid == false)
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