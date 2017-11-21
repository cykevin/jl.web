using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Infrastructure
{
    public static class StringExtension
    {
        public static int ToInt32(this string t)
        {
            int id;
            int.TryParse(t, out id);//这里当转换失败时返回的id为0
            return id;
        }

        public static float ToSingle(this string t)
        {
            float id;
            Single.TryParse(t, out id);//这里当转换失败时返回的id为0
            return id;
        }

        public static Double ToDouble(this string t)
        {
            Double id;
            Double.TryParse(t, out id);//这里当转换失败时返回的id为0
            return id;
        }

        public static bool IsNullOrEmpty(this string t)
        {
            return string.IsNullOrEmpty(t);
        }

        public static bool IsEquals(this string t,string other)
        {
            return string.Equals(t, other, StringComparison.OrdinalIgnoreCase);
        }
    }
}
