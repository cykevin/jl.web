using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Models
{
    public class UserInfoViewModel
    {
        public string RealName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string QQ { get; set; }

    }
}