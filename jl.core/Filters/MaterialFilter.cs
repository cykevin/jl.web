using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Filters
{
    public class MaterialFilter
    {
        public int? MaterialType { get; set; }
        public string Title { get; set; }

        public DateTime? AddTimeFrom { get; set; }
        public DateTime? AddTimeTo { get; set; }
    }
}
