using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = string.Empty;

        public Customer()
        {
            //CommonTask commonTask = new CommonTask();
            MachineName = CommonTask.GetMachineName();
        }


        public void Insert()
        {
            //CommonTask commonTask = new CommonTask();

            if(!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
            {
                //It will do some operation database
            }
        }


    }
}
