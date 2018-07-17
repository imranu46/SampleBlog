using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return Content("Users Controller");
        }
    }
}