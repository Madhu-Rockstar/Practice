using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Thimmaddi
    {
        public  void dad()
        {
            Console.WriteLine("It is a parent class:");
        }
        public static void dad2()
        {
            Console.WriteLine("It is a static child class:");
        }
    }
    class Madhu : Thimmaddi
    {
        public void son()
        {
            Console.WriteLine("It is a child class:");
        }
       public static void son2()
        {
            Console.WriteLine("It is a static child class:");
        }
        
    }
    class Inheritance
    {
        static void Main()
        {
            
            Madhu m = new Madhu();
            m.son();
            m.dad();
            Madhu.son2();          
        }
    }
}
