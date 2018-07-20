using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBlog.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SelectedTabAttribute : ActionFilterAttribute
    {
        private readonly string _selectedTab;

        public SelectedTabAttribute(string selectedTab)
        {
            _selectedTab = selectedTab;
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewData["SelectedTab"] = _selectedTab;
            filterContext.Controller.ViewBag.SelectedTab = _selectedTab;
        }
    }
}