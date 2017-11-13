using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class MaterialSearchModel
    {
        public string MaterialType { get; set; }
        public string Title { get; set; }

        public DateTime AddTimeFrom { get; set; }
        public DateTime AddTimeTo { get; set; }
    }
}