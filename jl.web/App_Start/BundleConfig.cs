using System.Web;
using System.Web.Optimization;

namespace JL.Web
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

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // bootstrap-fileinput
            bundles.Add(new StyleBundle("~/Content/fileinput").Include(
                "~/Content/bootstrap-fileinput/fileinput.css"));
            bundles.Add(new ScriptBundle("~/bundles/fileinput").Include(
                "~/Content/bootstrap-fileinput/fileinput.min.js",
                "~/Content/bootstrap-fileinput/fileinput_locale_zh.js"
                ));

            // uedit
            bundles.Add(new ScriptBundle("~/bundles/ueditor/").Include(
                "~/Content/ueditor/ueditor.config.js",
                "~/Content/ueditor/ueditor.all.min.js",
                "~/Content/ueditor/lang/zh-cn/zh-cn.js"
                ));

            // datapicker
            bundles.Add(new StyleBundle("~/Content/datepicker").Include(
                "~/Content/bootstrap-datepicker/css/bootstrap-datepicker.css"));
            
            bundles.Add(new ScriptBundle("~/bundles/datepicker/").Include(
                "~/Content/bootstrap-datepicker/js/bootstrap-datepicker.js",
                "~/Content/bootstrap-datepicker/locales/bootstrap-datepicker.zh-CN.min.js"
                ));
            
        }
    }
}
