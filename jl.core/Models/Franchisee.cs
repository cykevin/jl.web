using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    /// <summary>
    /// 加盟商
    /// 基本信息
    /// 申请时间、处理时间、处理结果
    /// </summary>
    public class Franchisee
    {
        public int AutoId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Weixin { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }

        public DateTime ApplyTime { get; set; }
        public DateTime ProcessTime { get; set; }
        public int Status { get; set; }
    }
}
