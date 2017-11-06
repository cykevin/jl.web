using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JL.Web.Helpers
{
    public static class TimeHelper
    {

        public static string ago(this DateTime time)
        {
            string[] periods = new string[] { "秒钟", "分钟", "小时", "天", "周", "月", "年", "十年" };
            double[] lengths = new double[] { 60, 60, 24, 7, 4.35, 12, 10 };

            double timeStamp = DateTimeToTimestamp(time);
            double now = DateTimeToTimestamp(DateTime.Now);
            double difference = now - timeStamp;

            string ret = string.Empty;
            string period = periods[0];

            for (int j = 0; difference >= lengths[j] && j < lengths.Length - 1; j++)
            {
                difference /= lengths[j];
                period = periods[j + 1];
            }


            difference = Math.Floor(difference);

            if (difference < 1)
                return "刚刚";
            //if (difference != 1)
            //{
            //    period += "s";
            //}
            return difference + " " + period + " 前";
        }


        static double DateTimeToTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }

    }
}