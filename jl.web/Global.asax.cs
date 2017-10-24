using jl.core;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Unity;
using WebMatrix.WebData;

namespace jl.web
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
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "jl_user", "UserId", "UserName", true);

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
                    if (!WebSecurity.UserExists("admin"))
                    {
                        WebSecurity.CreateUserAndAccount("admin", "666666");
                        Roles.AddUserToRole("admin", Consts.Role_Admin);
                    }   
                }
            }
        }

        private void RegContainer()
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection configuration = ConfigurationManager.GetSection(UnityConfigurationSection.SectionName)
                        as UnityConfigurationSection;
            configuration.Configure(container, "defaultContainer");
        }
    }
}
