using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public string BriefIntro { get; set; }
        public string Description { get; set; }
        
        public int? SortIndex { get; set; }        
        public int? CategoryId { get; set; }
        public DateTime AddTime { get; set; }
        public string Picture { get; set; }
        
        public float? RetailPrice { get; set; }        
        public float? MarketPrice { get; set; }

        public bool IsPublished { get; set; }

        public ProductModel()
        {
            SortIndex = 100;
            RetailPrice = 0;
            MarketPrice = 0;
            this.AddTime = DateTime.Now;
        }
    }
}