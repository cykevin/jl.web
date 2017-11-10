using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Infrastructure
{
    public class SqlFilter
    {
        public static string FilterQueryParameter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            input = input.Replace("_", "[_]");
            input = input.Replace("'", "''");
            return input;
        }
    }
}
