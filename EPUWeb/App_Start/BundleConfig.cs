using System.Web;
using System.Web.Optimization;

namespace EPUWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            /*Temp Admin*/
            bundles.Add(new StyleBundle("~/Admin/login/css").Include(
                      "~/Areas/Admin/src/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/Areas/Admin/src/vendors/font-awesome/css/font-awesome.min.css",
                      "~/Areas/Admin/src/vendors/nprogress/nprogress.css",
                      "~/Areas/Admin/src/vendors/animate.css/animate.min.css",
                      "~/Areas/Admin/src/build/css/custom.min.css"));
            bundles.Add(new StyleBundle("~/Admin/layout/css").Include(
                      "~/Areas/Admin/src/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/Areas/Admin/src/vendors/font-awesome/css/font-awesome.min.css",
                      "~/Areas/Admin/src/vendors/nprogress/nprogress.css",
                      "~/Areas/Admin/src/build/css/custom.min.css"));
            bundles.Add(new ScriptBundle("~/Admin/layout/js").Include(
                      "~/Areas/Admin/src/vendors/jquery/dist/jquery.min.js",
                      "~/Areas/Admin/src/vendors/bootstrap/dist/js/bootstrap.min.js",
                      "~/Areas/Admin/src/vendors/fastclick/lib/fastclick.js",
                      "~/Areas/Admin/src/vendors/nprogress/nprogress.js",
                      "~/Areas/Admin/src/build/js/custom.min.js"));
        }
    }
}
