using JL.Core;
using JL.Core.Common;
using JL.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JL.Web.Helpers
{
    public class ViewDataHelper
    {
        private IJLService jlService;

        public ViewDataHelper(IJLService jlService)
        {
            this.jlService = jlService;
        }
        
        public void InitializeYear(ViewDataDictionary viewData, int? year, string key = null)
        {
            List<int> years = new List<int>();

            int startYear = 2015;
            for (int i = DateTime.Now.Year; i >= startYear; i--)
            {
                years.Add(i);
            }

            viewData[key ?? "Years"] = new SelectList(years, year);
        }

        public void InitializeMonth(ViewDataDictionary viewData, int? month, string key = null)
        {
            string[] monthText ={
                                "一月","二月","三月","四月","五月","六月","七月","八月","九月","十月","十一月","十二月"
                            };

            Tuple<int, string>[] months = new Tuple<int, string>[12];
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = new Tuple<int, string>(i + 1, monthText[i]);
            }

            viewData[key ?? "Months"] = new SelectList(months, "Item1", "Item2", month);
        }

        public void InitializeCategories(ViewDataDictionary viewData,int? category,string key=null)
        {
            var pager = PageReq.Create();
            var categories = jlService.ProductCategoryPage(pager);

            if(categories!=null)
            {                
                viewData[key ?? "categories"] = new SelectList(categories.Data,"AutoId","Name", category);
            }            
        }
        
    }
}