using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class CommonTask
    {
        public static bool IsEmpty(string value)
        {
            if (value.Length > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static string GetMachineName()
        {
            return System.Environment.MachineName;
        }
    }
}
