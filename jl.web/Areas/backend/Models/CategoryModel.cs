using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jl.web.Areas.backend.Models
{
    public class CategoryModel
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public int Sort { get; set; }
    }
}