﻿using SampleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
                routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } 
                );            
            */
            var namespaces = new string[] { typeof(PostsController).Namespace };

            routes.MapRoute("Home", "", new { Controller = "Posts", Action = "Index" }, namespaces);

            routes.MapRoute("Login", "login", new { Controller = "Auth", Action = "Login" }, namespaces);


        }
    }
}
