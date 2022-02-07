using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Methodsdemo
    {
        static void fun() => Console.WriteLine("This is Rockstar Madhu");

        static void fun1(ref int a)
        {
            a = 10;
            Console.WriteLine($"the value of inside function is {a}");
        }

        static void fun3(int v1, int v2, ref int r1, ref int r2, ref int r3)
        {
            r1 = v1 + v2;
            r2 = v1 - v2;
            r3 = v1 * v2;
            Console.WriteLine($"The result shold be {r1} and {r2} and {r3}");
        }

        static void fun4(double v1, double v2, out double r1, out double r2, out double r3)
        {
            r1 = v1 + v2;
            r2 = v1 - v2;
            r3 = v1 * v2;
            Console.WriteLine($"The result shold be {r1} and {r2} and {r3}");
        }

        public void fun5()
        {
            Console.WriteLine("anna leka sukalu ekkuvaayyai");
        }


        static void Main()
        {
            //fun();
            // int a = 20;
            //fun1(ref a);
            //Console.WriteLine(a);
            //int r1 = 0, r2 = 0, r3 = 0;
            //fun3(10,20,ref r1,ref r2,ref r3);
            //Console.WriteLine($"The out result should be {r1} and {r2} and {r3}");
            double r1 = 0,r2 = 0,r3 = 0;
            fun4(10,20,out r1,out r2, out r3);
            Console.WriteLine($"The result should be {r1} and {r2} and {r3}");
            Methodsdemo num = new Methodsdemo();
            num.fun5();
            
        }

    }
}
