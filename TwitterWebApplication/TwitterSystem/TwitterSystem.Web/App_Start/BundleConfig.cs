using System.Web;
using System.Web.Optimization;

namespace TwitterSystem.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive-ajax*",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.signalR-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                   "~/Scripts/bootstrap.js",
                   "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/kendo.all.min.js",
                "~/Scripts/kendo/kendo.aspnetmvc.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
           "~/Content/kendo/kendo.common.min.css",
           "~/Content/kendo/kendo.black.min.css"));
        }
    }
}
