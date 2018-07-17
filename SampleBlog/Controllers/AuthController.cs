using SampleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBlog.Controllers
{
    public class AuthController : Controller
    {
        public  ActionResult Login()
        {
            return View(new AuthLogin() { Abc123 = "Hey it works...." });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if(ModelState.IsValid == false)
                return View(form);

            if(form.Username != "username")
            {
                ModelState.AddModelError("Username","UserName is not Valid");
                return View(form);
            }

            return Content("Form is Validated Successfully");
        }
    }
}