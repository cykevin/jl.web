using JL.Core.Common;
using JL.Core.Repositories;
using JL.Core.Models;
using System;

namespace JL.Core.Providers
{

    public class JLService : IJLService
    {
        readonly IUserRepository userRepository;
        readonly IArticleRepository articleRepository;

        public JLService(IUserRepository userRepository,
            IArticleRepository articleRepository)
        {
            this.userRepository = userRepository;
            this.articleRepository = articleRepository;
        }

        #region userprofile

        public void AddUser(UserProfile user)
        {
            userRepository.Add(user);
        }

        public void UpdateUser(UserProfile user)
        {
            userRepository.Update(user);
        }

        public PageData<UserProfile> UserPage(PageReq pageReq)
        {
            return userRepository.UserPage(pageReq);
        }

        public UserProfile GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUser(string username)
        {
            return userRepository.GetByUsername(username);
        }

        #endregion

        public PageData<Article> ArticlePage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public void DeleteFranchisee(Franchisee model)
        {
            throw new NotImplementedException();
        }

        public void DeleteMaterial(Material model)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product model)
        {
            throw new NotImplementedException();
        }


        public void InsertArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public void InsertMaterial(Material model)
        {
            throw new NotImplementedException();
        }

        public void InsertMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product model)
        {
            throw new NotImplementedException();
        }

        public PageData<Material> MaterialPage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }

        public PageData<Member> MemberPage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }

        public PageData<Product> ProductPage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }



        
    }
}
