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
            //Console.WriteLine(MyNonStaticClass.a);
            MyStaticClass.Increment();
            //Console.WriteLine(MyNonStaticClass.a);
            Console.WriteLine("************************");
            MyNonStaticClass test01 = new MyNonStaticClass();
            test01.Increment();
            //Console.WriteLine(test01.);
            test01.Increment();
            Console.WriteLine("************************");
            MyNonStaticClass test02 = new MyNonStaticClass();
            test02.Increment();
            test01.Increment();
            MyStaticClass.Increment();
            Console.WriteLine("************************");
            Console.ReadKey();
        }
    }
}
