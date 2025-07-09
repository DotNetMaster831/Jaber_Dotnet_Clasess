using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public string ComputerName
        {
            get
            {
                //CommonTask commonTask = new CommonTask();
                return CommonTask.GetMachineName();
            }
        }



        public void Insert()
        {
            //CommonTask commonTask = new CommonTask();
            if(!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(ComputerName))
            {

            }
        }
    }
}
