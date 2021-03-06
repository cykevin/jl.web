﻿using JL.Core;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebMatrix.WebData;

namespace JL.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("MySqlConnection", "jl_user", "UserId", "UserName", true);

                var provider = Membership.Provider;
                
                if (!Roles.RoleExists(Consts.Role_Admin))
                {
                    Roles.CreateRole(Consts.Role_Admin);
                }
                if (!Roles.RoleExists(Consts.Role_User))
                {
                    Roles.CreateRole(Consts.Role_User);
                }                

                // 创建管理员账号
                var adminUsers = Roles.GetUsersInRole(Consts.Role_Admin);
                if (adminUsers == null || adminUsers.Length < 1)
                {
                    if (!WebSecurity.UserExists("qssgadmin"))
                    {
                        WebSecurity.CreateUserAndAccount("qssgadmin", "fqmzwmhx");
                        Roles.AddUserToRole("qssgadmin", Consts.Role_Admin);
                    }   
                }
            }
        }
    }
}
