using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Input
    {
        public static int getint(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        public static string getstring(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static double getdouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        public static DateTime getdate(string question)
        {
            return DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
        }


    }
}
