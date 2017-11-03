using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jl.web.Areas.backend.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int SortIndex { get; set; }
        public int CategoryId { get; set; }
        public DateTime AddTime { get; set; }
        public string Picture { get; set; }

        public float RetailPrice { get; set; }
        public float MarketPrice { get; set; }
    }
}