using JL.Core.Common;
using JL.Core.Models;

namespace JL.Core
{
    public interface IJLService
    {
        // article
        void InsertArticle(Article article);
        PageData<Article> ArticlePage(PageReq pageReq);
        void DeleteArticle(Article article);

        // material
        void InsertMaterial(Material model);
        void DeleteMaterial(Material model);
        PageData<Material> MaterialPage(PageReq pageReq);

        // member
        void InsertMember(Member member);
        void DeleteMember(Member member);
        PageData<Member> MemberPage(PageReq pageReq);

        // product
        void InsertProduct(Product model);
        void DeleteProduct(Product model);
        PageData<Product> ProductPage(PageReq pageReq);

        // franchisee
        void DeleteFranchisee(Franchisee model);

        // userprofile
        void AddUser(UserProfile user);
        void UpdateUser(UserProfile user);
        UserProfile GetUser(int id);
        UserProfile GetUser(string username);
        PageData<UserProfile> UserPage(PageReq pageReq);
    }
}
