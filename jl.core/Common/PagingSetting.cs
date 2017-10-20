using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jl.core.Common
{
    public class PagingSetting
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalSize { get; set; }
    }

    public class PageReq<T>
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public T Data { get; set; }
    }

    public class PageData<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }

        public T Data { get; set; }
    }
}
