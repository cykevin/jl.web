using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Areas.backend.Models
{
    public class FranchiseeModel
    {
        public string Name { get; set; }
        public string Weixin { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }

        public DateTime? ApplyTime { get; set; }
    }
}