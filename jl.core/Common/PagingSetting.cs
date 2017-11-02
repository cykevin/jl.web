using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JL.Core.Common
{
    public class PagingSetting
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalSize { get; set; }
    }

    public class PageReq
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string OrderBy { get; set; }

        public PageReq()
        {
            PageIndex = 1;
            PageSize = 20;
        }
    }

    public class PageReq<T> : PageReq
    {
        public T Data { get; set; }
    }

    public class PageData<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }

        public IEnumerable<T> Data { get; set; }

        public static PageData<T> Create(int page,int size,int total, IEnumerable<T> data)
        {
            PageData<T> pageData = new PageData<T>();
            pageData.PageIndex = page;
            pageData.PageSize = size;
            pageData.TotalPage = total;
            pageData.Data = data;

            return pageData;
        }
    }
}
