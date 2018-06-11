using System.Configuration;
using System.Web;
using System.Web.Optimization;

namespace JL.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var domain = ConfigurationManager.AppSettings["static-domain"];
            var jsVersion = ConfigurationManager.AppSettings["static-js-version"] ?? "1.0";
            var cssVersion = ConfigurationManager.AppSettings["static-css-version"] ?? "1.0";

            // jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery",
                domain + "bundles/jquery").Include(
                        "~/Static/Scripts/jquery-{version}.js"));

            // jquery validate
            bundles.Add(new ScriptBundle("~/bundles/jqueryval",
                domain + "bundles/jqueryval").Include(
                "~/Static/Scripts/jquery.validate.js"));

            // swiper
            bundles.Add(new ScriptBundle("~/bundles/swiper",
                domain + "bundles/swiper").Include(
                      "~/Static/Content/swiper/js/swiper.jquery.min.js"));

            bundles.Add(new StyleBundle("~/Content/swiper",
                domain + "Content/swiper").Include(
                      "~/Static/Content/swiper/css/swiper.css"));

            // bootstrap          
            bundles.Add(new StyleBundle("~/Static/Content/bs",
                domain + "Static/Content/bs").Include(
                "~/Static/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Static/Content/site",
                domain + "Static/Content/site").Include(
                      "~/Static/Content/site.css"));

            // bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap",
                domain + "bundles/bootstrap").Include(
                      "~/Static/Scripts/bootstrap.js",
                      "~/Static/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/static/Content/font-awesome/css/font",
                domain + "static/Content/font-awesome/css/font").Include(
                "~/static/Content/font-awesome/css/font-awesome.min.css"));

            // bootstrap-fileinput
            bundles.Add(new StyleBundle("~/Static/Content/bootstrap-fileinput/fileinput",
                domain + "Static/Content/bootstrap-fileinput/fileinput").Include(
                "~/Static/Content/bootstrap-fileinput/fileinput.css"));

            bundles.Add(new ScriptBundle("~/bundles/fileinput",
                domain + "bundles/fileinput").Include(
                "~/Static/Content/bootstrap-fileinput/fileinput.min.js",
                "~/Static/Content/bootstrap-fileinput/fileinput_locale_zh.js"
                ));

            // uedit
            bundles.Add(new ScriptBundle("~/Static/Content/ueditor/ue").Include(
                "~/Static/Content/ueditor/ueditor.config.js",
                "~/Static/Content/ueditor/ueditor.all.min.js",
                "~/Static/Content/ueditor/lang/zh-cn/zh-cn.js"));

            // datepicker
            bundles.Add(new StyleBundle("~/Static/Content/bootstrap-datetimepicker/css/bootstrap-datetimepicker",
                domain + "Static/Content/bootstrap-datetimepicker/css/bootstrap-datetimepicker").Include(
                "~/Static/Content/bootstrap-datetimepicker/css/bootstrap-datetimepicker.css"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker",
                domain + "bundles/datepicker").Include(
                "~/Static/Content/bootstrap-datetimepicker/js/bootstrap-datetimepicker.js",
                "~/Static/Content/bootstrap-datetimepicker/js/locales/bootstrap-datetimepicker.zh-CN.js"
                ));

            // backend
            bundles.Add(new StyleBundle("~/Content/backend",
                domain + "Content/backend").Include(
                "~/Static/Content/metisMenu/metisMenu.css",
                "~/Static/Content/sbadmin2/css/sb-admin-2.css"));

            bundles.Add(new ScriptBundle("~/bundles/backend",
                domain + "bundles/backend").Include(
                "~/Static/Scripts/jquery-{version}.js",
                "~/Static/Scripts/bootstrap.js",
                "~/Static/Content/metisMenu/metisMenu.js",
                "~/Static/Content/sbadmin2/js/sb-admin-2.js"));

            // cropper/Content/cropperjs-1.1.3/cropper.css
            bundles.Add(new StyleBundle("~/Static/Content/cropper",
               domain + "Static/Content/cropper").Include(
               "~/Static/Content/cropperjs-1.1.3/cropper.css"));
            bundles.Add(new ScriptBundle("~/bundles/cropper",
                domain + "bundles/cropper").Include(
                "~/Static/Content/cropperjs-1.1.3/cropper.js"));

            // login.js
            bundles.Add(new ScriptBundle("~/Static/Scripts/login",
                domain + "Static/Scripts/login").Include(
                "~/Static/Scripts/login.js"));

            //BundleTable.EnableOptimizations = false;
            //bundles.UseCdn = false;
        }
    }
}
