using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less10_01
{
    static class MyStaticClass
    {
        static int a;
        public static void Increment()
        {
            a++;
            Console.WriteLine(a);
        }
    }
}
