using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core
{
    public class Consts
    {
        public const string Role_Admin = "admin";
        public const string Role_User = "user";

        #region setting

        public const string SettingItem_Keywords = "keywords";
        public const string SettingItem_Description = "description";
        public const string SettingItem_Address = "address";
        public const string SettingItem_Copyright = "copyright";
        public const string SettingItem_Icpno = "icpno";
        public const string SettingItem_Phone = "phone";

        #endregion

        #region 产品

        public const int ProductStatus_Public = 0;// 已发布/对外展示
        public const int ProductStatus_Private = 1;// 已发布/对外展示


        #endregion

        #region 资讯

        public const int ArticleStatus_Published = 0;
        public const int ArticleStatus_Private = 1;
        #endregion
    }
}
