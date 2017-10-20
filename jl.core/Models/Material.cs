﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Models
{
    /// <summary>
    /// 素材资源
    /// 类型：图片、视频
    /// </summary>
    public class Material
    {
        public int AutoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string FileName { get; set; }
        public string MaterialType { get; set; }

        public int PageViews { get; set; }
        public int SortIndex { get; set; }
        public int Status { get; set; }
    }
    
}