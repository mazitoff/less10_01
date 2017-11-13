using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less10_01
{
    public class MyNonStaticClass
    {
        static int a;
        public int Increment()
        {
            return a = +1;
        }

    }
}
