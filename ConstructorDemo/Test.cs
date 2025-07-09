using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    public class Test
    {

        public int i;
        public bool b;
        public string s;

        public Test(int a, bool b, string c)
        {
            i = a;
            s = c;
            this.b = b;
        }

    }

}
