using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Filters
{
    public class ProductFilter
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }
}
