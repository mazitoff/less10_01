using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            MyStaticClass.Increment();
            MyStaticClass.Increment();

            MyNonStaticClass test01 = new MyNonStaticClass();
            test01.Increment();
            test01.Increment();

            MyNonStaticClass test02 = new MyNonStaticClass();
            test02.Increment();
            MyStaticClass.Increment();
        }
    }
}
