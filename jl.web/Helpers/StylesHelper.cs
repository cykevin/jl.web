using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace JL.Web.Helpers
{
    public static class StylesHelper
    {
        public static IHtmlString Render(string value)
        {
            var tagFormat = "<link href=\"{0}{{0}}?v={1}\" rel=\"stylesheet\"/>";
            
            var domain = System.Configuration.ConfigurationManager.AppSettings["static-domain"];
            var version = System.Configuration.ConfigurationManager.AppSettings["static-css-version"];

            var bundle = BundleTable.Bundles.GetBundleFor(value);

            if (bundle != null)
            {
                return Styles.Render(value);
            }

            if (domain.EndsWith("/"))
            {
                domain = domain.TrimEnd('/');
            }
            var format = string.Format(tagFormat, domain, version);            
            return Styles.RenderFormat(format, value);
        }
    }
}