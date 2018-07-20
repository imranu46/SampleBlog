using SampleBlog.Areas.Admin.ViewModels;
using SampleBlog.Infrastructure;
using SampleBlog.Models;
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View(new UsersIndex()
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}