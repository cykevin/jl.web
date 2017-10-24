using jl.core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Providers
{

    public class JLService
    {
        // article
        public void InsertArticle(Article article) { }
        public PageData<Article> ArticlePage(PageReq pageReq) { throw new NotImplementedException(); }
        public void DeleteArticle(Article article) { }

        // material
        public void InsertMaterial(Material model) { }
        public void DeleteMaterial(Material model) { }
        public PageData<Material> MaterialPage(PageReq pageReq) { throw new NotImplementedException(); }

        // member
        public void InsertMember(Member member) { }
        public void DeleteMember(Member member) { }
        public PageData<Member> MemberPage(PageReq pageReq) { throw new NotImplementedException(); }

        // product
        public void InsertProduct(Product model) { }
        public void DeleteProduct(Product model) { }
        public PageData<Product> ProductPage(PageReq pageReq) { throw new NotImplementedException(); }

        // franchisee
        public void DeleteFranchisee(Franchisee model) { }

    }
}
