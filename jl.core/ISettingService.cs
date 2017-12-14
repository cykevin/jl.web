using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core
{
    public interface ISettingService
    {
        // setting
        IList<Models.Setting> GetSettingList();
        Models.Setting GetSetting(string key);
        Models.Setting SaveSetting(Models.Setting setting);
        Models.Setting SaveSetting(string key, string value);
    }
}
