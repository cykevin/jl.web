using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class MaterialModel
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string Picture { get; set; }

        public DateTime? AddTime { get; set; }
        public bool Status { get; set; }// 对外开放
    }
}