using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    /// <summary>
    /// 团队成员
    /// </summary>
    public class Member
    {
        public int AutoId { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public string Description { get; set; }
        
        public string Phone { get; set; }
        public string Weixin { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime JoinTime { get; set; }
        public string Picture { get; set; }

        public string Words { get; set; }// 寄语

        public int SortIndex { get; set; }
        public int Status { get; set; }
    }
}
