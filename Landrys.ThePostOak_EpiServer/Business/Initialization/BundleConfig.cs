using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Optimization;

namespace Landrys.ThePostOak_EpiServer.Business.Initialization
{
    [InitializableModule]
    class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.UseCdn = true;

            var jqueryCdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.3.js"; ;
            var jqueryBundle = new ScriptBundle("~/bundles/jquery", jqueryCdnPath);

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                        .Include("~/Static/js/jquery-{version}.min.js")
                        .Include("~/Scripts/js/jquery-1.7.1.min.js")
                        .Include("~/Static/js/jquery.cycle.all.min.js")
                        .Include("~/Static/js/lightbox.min.js")
                        .Include("~/Static/js/jquery.min.js")
                        .Include("~/Static/js/jquery.js")
                        .Include("~/Static/js/bootstrap.min.js"));

            jqueryBundle.CdnFallbackExpression = "window.jquery";

            bundles.Add(new ScriptBundle("~/bundles/Static/modernizr").Include("~/Static/js/modernizr-*"));
            bundles.Add(jqueryBundle);

            bundles.Add(new StyleBundle("~/bundles/css")
                   .Include("~/Static/css/bootstrap.min.css", new CssRewriteUrlTransform())
                   .Include("~/Static/css/clean-blog.min.css")
                   .Include("~/Static/css/lightbox.css")
                   .Include("~/Static/css/map.css")
                   .Include("~/Static/css/style.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;

        }

        public void Uninitialize(InitializationEngine context)
        {

        }
        public void Preload(string[] parameters)
        {

        }
    }
}