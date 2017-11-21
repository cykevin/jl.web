using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class BannerModel
    {
        public string Picture { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }        
        public string BackgroundColor { get; set; }
        public string Url { get; set; }

        public int Status { get; set; }
        public int SortIndex { get; set; }
    }
}