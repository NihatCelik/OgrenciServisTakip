﻿using System.Web;
using System.Web.Optimization;

namespace OgrenciServisTakip
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var jqueryCdnPath = "//cdnjs.cloudflare.com/ajax/libs/raphael/2.1.0/raphael-min.js";
            bundles.Add(new ScriptBundle("~/bundles/jquery",
                       jqueryCdnPath));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery.min.js",
                         "~/Scripts/bootstrap.min.js",
                         "~/Scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/ionicons.css",
                      "~/Content/AdminLTE.css"));
        }
    }
}
