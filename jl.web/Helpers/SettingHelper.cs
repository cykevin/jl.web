using JL.Core;
using JL.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Helpers
{
    public class SettingHelper
    {        
        private static ISettingService settingService;

        static SettingHelper()
        {
            settingService = (ISettingService)UnityConfig.Container.Resolve(typeof(SettingService), "ISettingService");
        }

        public static string GetKey()
        {
            return GetSettingByKey(Consts.SettingItem_Keywords);
        }
        public static string GetDescription()
        {
            return GetSettingByKey(Consts.SettingItem_Description);
        }

        public static string GetSettingByKey(string key)
        {
            var setting = settingService.GetSetting(key);
            if(setting!=null)
            {
                return setting.Value;
            }

            return null;
        }

    }
}