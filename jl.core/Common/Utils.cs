using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Common
{
    using JL.Core.Common.Attributes;
    using System.Reflection;
    public static class Utils
    {
        public static string GetJobSummaryLevelToCode(int level)
        {
            string level2 = "";
            switch (level)
            {
                case 1:
                    level2 = "一级";
                    break;
                case 2:
                    level2 = "二级";
                    break;
                case 3:
                    level2 = "三级";
                    break;
                case 4:
                    level2 = "四级";
                    break;
                case 5:
                    level2 = "五级";
                    break;
                default:
                    break;
            }
            return level2;
        }

        public static string GetDescription(Enum obj)
        {
            string objName = obj.ToString();
            Type t = obj.GetType();

            FieldInfo fi = t.GetField(objName);
            if (fi == null)
                return null;

            EnumDisplayAttribute[] arrDesc = (EnumDisplayAttribute[])fi.GetCustomAttributes(typeof(EnumDisplayAttribute), false);

            if (arrDesc != null &&
                arrDesc.Length > 0)
            {
                return arrDesc[0].Description;
            }
            else
            {
                return objName;
            }
        }

    }
}
