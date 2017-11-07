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

        public static PageReq Create(int pageIndex = 1, int pageSize = 20)
        {
            PageReq pager = new PageReq();
            pager.PageIndex = pageIndex;
            pager.PageSize = pageSize;
            return pager;
        }
    }

    public class PageReq<T> : PageReq
    {
        public T Data { get; set; }

        public static PageReq<T> Create(T t,int pageIndex = 1, int pageSize = 20)
        {
            PageReq<T> pager = new PageReq<T>();
            pager.PageIndex = pageIndex;
            pager.PageSize = pageSize;
            pager.Data = t;
            return pager;
        }
    }

    public class PageData<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int TotalCount { get; set; }

        public IEnumerable<T> Data { get; set; }

        public static PageData<T> Create(int page,int size,int totalPage,int totalCount, IEnumerable<T> data)
        {
            PageData<T> pageData = new PageData<T>();
            pageData.PageIndex = page;
            pageData.PageSize = size;
            pageData.TotalPage = totalPage;
            pageData.TotalCount = totalCount;
            pageData.Data = data;

            return pageData;
        }
    }
}
