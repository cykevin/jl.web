using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    public class Banner
    {
        public int AutoId { get; set; }

        public string Picture { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public int SortIndex { get; set; }
        public string BackgroundColor { get; set; }
        public string Url { get; set; }
        public int Status { get; set; }
    }
}
