﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    /// <summary>
    /// 产品
    /// 信息
    /// 
    /// 零售价、市场价
    /// </summary>
    public class Product
    {
        public int AutoId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string BriefIntroduction { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime AddTime { get; set; }

        public float RetailPrice { get; set; }
        public float MarketPrice { get; set; }

        public int PageViews { get; set; }
        public int SortIndex { get; set; }
        public int Status { get; set; }

        /// <summary>
        /// 作为新品推荐（0（是），1（不是））
        /// </summary>
        public int IsRecommendAsNew { get; set; }

        public virtual ICollection<ProductCategory> Categories { get; set; }

        public Product()
        {
            this.Categories = new List<ProductCategory>();
        }
    }

    public class ProductCategory
    {
        public int AutoId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Picture { get; set; }
        
        public string Path { get; set; }
        public int Depth { get; set; }
        public int ParentId { get; set; }

        public int PageViews { get; set; }
        public int SortIndex { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            this.Products = new List<Product>();
        }
    }

    public class ProductCategoryLink
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }

}
