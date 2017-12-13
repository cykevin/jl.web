using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JL.Utils
{
    public class JsonHelper
    {
        public static string ObjectToString(object value)
        { 
            return JsonConvert.SerializeObject(value);
        }

        public static T StringToObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
