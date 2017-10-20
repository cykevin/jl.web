using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    /// <summary>
    /// 文章
    /// 浏览量、标签
    /// </summary>
    public class Article
    {
        public int AutoId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Picture { get; set; }
        public DateTime AddTime { get; set; }
        public string Tags { get; set; }

        public int PageViews { get; set; }
        public int SortIndex { get; set; }
        public int Status { get; set; }
    }
}
