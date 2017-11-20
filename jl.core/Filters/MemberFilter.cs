using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Filters
{
    public class MemberFilter
    {
        public string NickName { get; set; }
        public DateTime? JoinTimeFrom { get; set; }
        public DateTime? JoinTimeTo { get; set; }
    }
}
