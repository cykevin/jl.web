using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class MemberModel
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        
        public string Email { get; set; }

        public string Picture { get; set; }
        public string Words { get; set; }
        public string Weixin { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public DateTime? JoinTime { get; set; }

        public int Status { get; set; }
        
        public int SortIndex { get; set; }
    }
}