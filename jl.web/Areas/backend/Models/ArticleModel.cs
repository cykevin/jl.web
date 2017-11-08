using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class ArticleModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime? AddTime { get; set; }

        public bool IsPublished { get; set; }
    }
}