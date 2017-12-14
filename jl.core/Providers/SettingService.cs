using JL.Core.Models;
using JL.Core.Repositories;
using JL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Providers
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository settingRepository;

        public SettingService(ISettingRepository settingRepository)
        {
            this.settingRepository = settingRepository;

            settings = GetSettingList();
        }

        #region setting

        private IList<Setting> settings;

        public Models.Setting GetSetting(string key)
        {
            if (string.IsNullOrEmpty(key))
                return null;

            // 更新
            if (settings != null)
            {
                var oldOne = settings.FirstOrDefault(s => string.Equals(key, s.Key));
                return oldOne;
            }

            return null;
        }

        public IList<Models.Setting> GetSettingList()
        {
            if (settings != null)
            {
                return settings;
            }
            else
            {
                settings = settingRepository.GetList().ToList();
            }
            return settings;
        }

        public Models.Setting SaveSetting(Models.Setting setting)
        {
            if (setting == null)
                return null;

            if (settings != null)
            {
                // 更新
                var oldOne = settings.FirstOrDefault(s => string.Equals(setting.Key, s.Key));
                if (oldOne != null)
                {
                    setting.AutoId = oldOne.AutoId;
                    if (!string.Equals(setting.Value, oldOne.Value))
                    {
                        settingRepository.Update(setting);
                        settings.Remove(oldOne);
                        settings.Add(setting);
                    }
                    return setting;
                }
            }

            // 新增
            var id = settingRepository.Insert(setting);
            setting.AutoId = id;
            settings.Add(setting);
            return setting;
        }

        public Models.Setting SaveSetting(string key, string value)
        {
            if (key.IsNullOrEmpty())
                return null;

            if (settings != null)
            {
                // 更新
                var oldOne = settings.FirstOrDefault(s => string.Equals(key, s.Key));
                if (oldOne != null)
                {
                    if (!string.Equals(value, oldOne.Value))
                    {
                        oldOne.Value = value;
                        settingRepository.Update(oldOne);
                    }
                    return oldOne;
                }
            }

            // 新增            
            var newSetting = new Models.Setting();
            newSetting.Key = key;
            newSetting.Value = value;

            var id = settingRepository.Insert(newSetting);
            newSetting.AutoId = id;
            settings.Add(newSetting);
            return newSetting;
        }


        #endregion

    }
}
