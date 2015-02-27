using System.Web;
using System.Web.Optimization;

namespace vls
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterStyleBundles(bundles);
            RegisterJavascriptBundles(bundles);
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css")
                .Include("~/Content/css/materialize.min.css")
                .Include("~/Content/css/main.css")
                .Include("~/Content/css/c3.min.css"));
        }

        private static void RegisterJavascriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js")
                .Include("~/Content/js/lib/moment.min.js")
                .Include("~/Content/js/lib/jquery.min.js")
                .Include("~/Content/js/lib/accounting.min.js")
                .Include("~/Content/js/lib/materialize.min.js")
                .Include("~/Content/js/lib/knockout.js")                
                .Include("~/Content/js/lib/d3.min.js")
                .Include("~/Content/js/lib/c3.min.js")
                .Include("~/Content/js/lib/app.js"));
        }
    }
}
