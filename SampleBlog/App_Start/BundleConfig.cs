using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SampleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new StyleBundle("~/admin/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/admin.css")
                );

            bundles.Add(
                new StyleBundle("~/styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/site.css")
                );

            bundles.Add(
                new ScriptBundle("~/admin/scripts")
                .Include("~/Scripts/jquery-3.3.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Areas/Admin/Scripts/form.js")
                );

            bundles.Add(
                new ScriptBundle("~/scripts")
                .Include("~/Scripts/jquery-3.3.1.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                );
        }
    }
}