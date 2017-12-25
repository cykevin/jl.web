using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace JL.Web.Helpers
{
    public class ScriptsHelper
    {
        public static IHtmlString Render(string value)
        {
            var tagFormat = "<script src=\"{0}{{0}}?v={1}\" type=\"text/javascript\"></script>";

            var domain = System.Configuration.ConfigurationManager.AppSettings["static-domain"];
            var version = System.Configuration.ConfigurationManager.AppSettings["static-js-version"];

            var bundle = BundleTable.Bundles.GetBundleFor(value);

            if (bundle != null)
            {
                return Scripts.Render(value);
            }

            if (domain.EndsWith("/"))
            {
                domain = domain.TrimEnd('/');
            }
            var format = string.Format(tagFormat, domain, version);
            return Scripts.RenderFormat(format, value);
        }
    }
}