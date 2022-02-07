using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Datetimemodule
    {
        static void Main()
        {
            DateTime dt = new DateTime(); //it sets the default values like 01-01-0001 like that
            dt = new DateTime(2001,05,13);
            dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("the longer version is : " + dt.ToLongDateString());
            Console.WriteLine("the shorter version is : " + dt.ToShortDateString());
            Console.WriteLine("the longer varsion of time is : " + dt.ToLongTimeString());
            Console.WriteLine("the shorter version of time is : " + dt.ToShortTimeString());
            Console.WriteLine("the custom foraamt is :"+dt.ToString("dd-MM-yyyy hh-mm-ss tt"));
            Console.WriteLine("the year is {0} and month is {1} and day is {2} ",dt.Year,dt.Month,dt.Day);
        }
    }
}
