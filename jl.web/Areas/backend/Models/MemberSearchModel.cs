using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class MemberSearchModel
    {
        public string NickName { get; set; }
        public DateTime? JoinTimeFrom { get; set; }
        public DateTime? JoinTimeTo { get; set; }
    }
}